//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray(double[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.NextDouble() * (100.0 + 100.0) - 100.0;
        }
    } 
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"  {Math.Round(array[i, j], 3)}  ");
        }
        Console.WriteLine();
    } 
}

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

double ArraySearch(double[,] array)
{
    Console.WriteLine("Задайте позицию элемента в двумерном массиве двумя натуральными чесилами");
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
                if (i == x && j == y)
                {
                    return array[i, j];
                }
        }
    } 
    return -1; 
}

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

void FillNaturalArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 100);
        }
    } 
}

void PrintNaturalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"  {array[i, j]}  ");
        }
        Console.WriteLine();
    } 
}

void ArithmeticMeanInColumnArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double a = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            a += (double)array[i, j];   
        }
        Console.WriteLine($"Среднее арифметическое {j + 1} столбца = {Math.Round(a / array.GetLength(1), 1)}");
    } 
}

//------------------------------------------------------------------------------

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int RowSize = 5;
int ColumnSize = 5;

double[,] Array = new double[RowSize, ColumnSize];

FillArray(Array);
PrintArray(Array);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

double a = ArraySearch(Array);
Console.WriteLine($" По указанной позиции находится {a}, если значение -1, значит, такой позиции нет в массиве");

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

int[,] NaturalArray = new int[RowSize, ColumnSize];
FillNaturalArray(NaturalArray);
PrintNaturalArray(NaturalArray);
ArithmeticMeanInColumnArray(NaturalArray);




