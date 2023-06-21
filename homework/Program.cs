//задание1
//Наптшите цикл, который принимает на вход два числа A и B
//и возводит число A в натуральную степень B


int numA (string message)
{
    System.Console.WriteLine(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int numB (string message)
{
    System.Console.WriteLine(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int Exp (int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result  = result * A;
    } 
    return result;
}

int A = numA("Введите первое число: ");
int B = numB("Введите второе число: ");
if (B < 0)
{
    System.Console.WriteLine("Второе число не может быть меньше 0");
    return;
}
int answer = Exp (A,B);
System.Console.WriteLine($"Число {A} в степени {B}: {answer}");

//задание2
//Наптшите программу, которая принимает на вход число 
//и выдает сумму цифр в числе

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(System.Console.ReadLine());

int Summa (int symbol)
{
    if (symbol < 0)
    {
        symbol*= -1;
    }
    int answer = 0;
    while (symbol > 0)
    {
        answer = answer + symbol%10;
        symbol/=10;
    }
    return answer;
}
int result = Summa(num);
System.Console.WriteLine($"Сумма цифр в числе {num}: {result}");

//задача3
//Напишите программу, которая задает массив из 8 элементов и 
//выводит их на экран
System.Console.WriteLine("Задайте количество элементов в массиве:");
int N = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Задайте минимальное возможное число в массиве:");
int A = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Задайте максимальное возможное число в массиве:");
int B = Convert.ToInt32(System.Console.ReadLine());
int [] arr = new int[N];
Random rand = new Random();

void FillArray(int [] arr, int N)
{
    for (int i = 0; i < N; i++)
    {
        arr [i] = rand.Next(A, (B+1));
    }
}

void PrintArray(int [] arr, int N)
{
    for (int i = 0; i < N; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}
FillArray (arr, N);
PrintArray (arr, N);




