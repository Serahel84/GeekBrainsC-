

void PrintMessage(string a)
{
    Console.WriteLine(a);
}

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void palindrome(int Number)
{
    string NumberString = Number.ToString();
    char[] CharArray = NumberString.ToCharArray();
    Array.Reverse(CharArray);
    bool checker = false;
    int Counter = 0;
    int Value = Number;
    if (Number < 0)
    {
        Console.WriteLine("число не является полиндромом");
    }
    else
    {
    while (Number > Value / 2)
        {
            Number = Number / 10;
            if (CharArray[Counter] !=  NumberString[Counter])
            {
                checker = false;
                break;
            }
            else checker = true;
            Counter++;
        }
        if (checker)
        {
            Console.WriteLine("число является полиндромом");
        }
        else
        {
            Console.WriteLine("число не является полиндромом");
        }
    }
}

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double CoordLength(double X, double Y, double Z, double U, double V, double W)
{
    double Length = Math.Sqrt(Math.Pow(U - X, 2) + Math.Pow(V - Y, 2) + Math.Pow(W - Z, 2));
    return Length;
}
//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubeNumbers(int N)
{
    int PowN = 0;
    if (N > 0)
    {
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(Math.Pow(i, 3));
     }
    }
    else 
    {
        Console.WriteLine("некорректное число");
    }
}

//------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
PrintMessage("введите число");
int Value = int.Parse(Console.ReadLine());
palindrome(Value);

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double A, B, C, D, E, F, L = 0;
PrintMessage("введите три числа (координаты первой точки)");
A = double.Parse(Console.ReadLine());
B = double.Parse(Console.ReadLine());
C = double.Parse(Console.ReadLine());
PrintMessage("введите три числа (координаты второй точки)");
D = double.Parse(Console.ReadLine());
E = double.Parse(Console.ReadLine());
F = double.Parse(Console.ReadLine());
L = CoordLength(A, B, C, D, E, F);
Console.WriteLine($"расстояние между точками =  {L}");

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
PrintMessage("введите число больше 0");
Value = int.Parse(Console.ReadLine());
CubeNumbers(Value);
