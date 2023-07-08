//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void SetPositRandArray(int[] array)
{
    Random X = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = X.Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

void PrintPositNumArr(int[] array)
{
    int Counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Counter++;
        }
    }
    Console.WriteLine($"четных чисел в массиве {Counter}");
}

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void SetRandArray(int[] array)
{
    Random X = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = X.Next(-99, 100);
    }
}

int GetSumOfOddPos(int[] array)
{
    int Summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            Summ += array[i];
        }
    }
    return Summ;
}

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void SetDoubleRandArray(double[] array)
{
    Random X = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = X.NextDouble() * (100.0 + 100.0) - 100.0;
    }
}

void PrintDArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(Math.Round(array[i], 2));
    }
}

double GetDiffMinMax(double[] array)
{
    double min = array[0], max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
             min = array[i];
        }
    }
    return max - min;
}

//--------------------------------------------------------------------------------

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int Size = 6;
int[] Array = new int[Size];
SetPositRandArray(Array);
PrintArray(Array);
PrintPositNumArr(Array);

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

SetRandArray(Array);
PrintArray(Array);
int SummOddPos = GetSumOfOddPos(Array);
Console.WriteLine($"сумму элементов, стоящих на нечётных позициях = {SummOddPos}");

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] DArray = new double[Size];
SetDoubleRandArray(DArray);
PrintDArray(DArray);
double Difference = GetDiffMinMax(DArray);
Console.WriteLine($"разницу между максимальным и минимальным элементов массива = {Math.Abs(Math.Round(Difference, 2))}");
