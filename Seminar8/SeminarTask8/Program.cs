//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillNaturalArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    } 
}

void SortRowNaturalArray(int[,] array)
{
    Random rand = new Random();
    int Temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); )
        {
            if (j < array.GetLength(1) - 1 && array[i, j] < array[i, j + 1])
            {
                Temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = Temp;
                j = 0;
            }
            else j++;
        }
    } 
}


void PrintNaturalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    } 
}

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int GetNumberRowMinSumElements(int[,] array)
{
    int Min = 0;
    int Temp;
    int Index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Temp += array[i, j];
        }
        if (i == 0)
        {
            Min = Temp;
        }
        if (Min > Temp)
        {
            Min = Temp;
            Index = i;
        }
        
    } 
    return Index + 1;
}

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void MatrixMultiply()
{
   int FirstMX, FirstMY, SecondMX, SecondMY;
   Console.WriteLine("enter the number of rows and columns of the first matrix");
   FirstMX = int.Parse(Console.ReadLine());
   FirstMY = int.Parse(Console.ReadLine());
   Console.WriteLine("enter the number of rows and columns of the second matrix");
   SecondMX = int.Parse(Console.ReadLine());
   SecondMY = int.Parse(Console.ReadLine());
   if (FirstMY == SecondMX )
   {
      int[,] MatrixPrime = new int[FirstMX, FirstMY];
      int[,] MatrixSecond = new int[SecondMX, SecondMY];
      
      Console.WriteLine("fill out the first one matrix ");
      for (int i = 0; i < FirstMX; i++)
      {
         for (int j = 0; j < FirstMY; j++)
         {
            MatrixPrime[i, j] = int.Parse(Console.ReadLine());
         }
      }
      Console.WriteLine("fill out the second one matrix");
      for (int i = 0; i < SecondMX; i++)
      {
         for (int j = 0; j < SecondMY; j++)
         {
            MatrixSecond[i, j] = int.Parse(Console.ReadLine());
         }
      }

      int[,] MatrixMult = new int [SecondMX, SecondMY];
      for (int x = 0; x < SecondMX; x++)
      {
         for (int y = 0; y < SecondMY; y++)
         {
            for (int i = 0; i < SecondMX; i++)
            {
               MatrixMult[x, y] += MatrixPrime[x, i] * MatrixSecond[i, y];
            }
         }
      }
      Console.WriteLine("the result of matrix multiplication: ");
      for (int i = 0; i < SecondMX; i++)
      {
         for (int j = 0; j < SecondMY; j++)
         {
            Console.Write($" {MatrixMult[i, j]} ");
         }
         Console.WriteLine();
      }
      
   }
   else Console.WriteLine("matrices cannot be multiplied ");
}

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void Fill3DArray(int[,,] array)
{
   bool Inspector;
   Random randomius = new Random();
   int rand;
   for (int x = 0; x < array.GetLength(0); x++)
   {
      for (int y = 0; y < array.GetLength(1); y++)
      {
         for (int z = 0; z < array.GetLength(2); z++)
         {
            Inspector = true;
            rand = randomius.Next(10, 100);
            for (int i = 0; i < array.GetLength(0); i++)
            {
               for (int j = 0; j < array.GetLength(1); j++)
               {
                  for (int k = 0; k < array.GetLength(2); k++)
                  {
                     if (rand == array[i,j,k])
                     {
                        Inspector = false;
                        break;
                     }
                  }
               }
            } 
            if (!Inspector)
            {
               z--;
            }
            else array[x,y,z] = rand;
         }
         
      }
   }
}

void Print3DArray(int [,,] array)
{
   for (int x = 0; x < array.GetLength(0); x++)
   {
      for (int y = 0; y < array.GetLength(1); y++)
      {
         for (int z = 0; z < array.GetLength(2); z++)
         {
            Console.WriteLine($" {array[x,y,z]} ({x},{y},{z})");
         }
      }
   }
}

//Задача 62. Напишите программу, которая заполнит спирально массив.

void FillSpiralNaturalArray(int[,] array)
{
   int Count = 1;
   int Arrow = 1;
   int x = 0;
   int y = 0;

   while (Count <= array.GetLength(0) * array.GetLength(1))
   {
      if (Count < array.GetLength(1) * 2 + array.GetLength(0))
      {
         if (Arrow == 1 && x == array.GetLength(1) - 1)
         {
            Arrow = 2;
         }
         if (Arrow == 2 && y == array.GetLength(0) - 1 )
         {
            Arrow = 3;
         }
         if (Arrow == 3 && x == 0)
         {
            Arrow = 4;
         }
         if (Arrow == 4 && y == 0)
         {
            Arrow = 1;
         }
      }
      if (Count >= array.GetLength(1) * 2 + array.GetLength(0))
      {
         if (Arrow == 1 && array[y, x + 1] != 0)
         {
            Arrow = 2;
         }
         if (Arrow == 2 && array[y + 1, x] != 0)
         {
            Arrow = 3;
         }
         if (Arrow == 3 && array[y, x - 1] != 0)
         {
            Arrow = 4;
         }
         if (Arrow == 4 && array[y -1, x] != 0)
         {
            Arrow = 1;
         }
      }
      array[y, x] = Count;

      if (Arrow == 1)
      {
         x++;
      }
      if (Arrow == 2)
      {
         y++;
      }
      if (Arrow == 3)
      {
         x--;
      }
      if (Arrow == 4)
      {
         y--;
      } 
      Count++;
   }
}

//--------------------------------------------------------------------------------------

int RowSize = 5;
int ColumnSize = 5;

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] NaturalArray = new int[RowSize, ColumnSize];
FillNaturalArray(NaturalArray);
PrintNaturalArray(NaturalArray);
SortRowNaturalArray(NaturalArray);
Console.WriteLine();
PrintNaturalArray(NaturalArray);

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int index = GetNumberRowMinSumElements(NaturalArray);
Console.Write($" строка с наименьшей суммой элементов {index} ");
Console.WriteLine();

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

MatrixMultiply();
Console.WriteLine();

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Array3D = new int[4, 4, 4];
Fill3DArray(Array3D);
Print3DArray(Array3D);
Console.WriteLine();

//Задача 62. Напишите программу, которая заполнит спирально массив

int[,] SpiralArray = new int[6, 4];
FillSpiralNaturalArray(SpiralArray);
PrintNaturalArray(SpiralArray);
