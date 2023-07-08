//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int PowFoo(int a, int b)
{
    int A = a;
    for (int i = 1; i < b; i++)
    {
        A *= a;
    }   
    return A;
}

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfNumbers(int a)
{
    int A = 0;
    while (a > 0)
    {
        A += a % 10;
        a /= 10;
    }
    return A;
}

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void SetRandArray(int[] array)
{
    Random X = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = X.Next(0, 100);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

//--------------------------------------------------

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int a, b;
Console.WriteLine("введите два числа");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
int A = PowFoo(a, b);
Console.WriteLine($" первое число в степени второго числа = {A}");

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("введите число");
a = int.Parse(Console.ReadLine());
A = SumOfNumbers(a);
Console.WriteLine($" сумма всех цифр в числе = {A}");

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] Array = new int[8];
SetRandArray(Array);
PrintArray(Array);