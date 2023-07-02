// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.WriteLine("введите пятизначное число");
int Number;
Number = int.Parse(Console.ReadLine());

string NumberString = Number.ToString();
char[] CharArray = NumberString.ToCharArray();
Array.Reverse(CharArray);
//Console.WriteLine(CharArray);
bool checker = false;

while (Number > 100)
{
    int Counter = 0;
    Number = Number / 10;
    if (CharArray[Counter] !=  NumberString[Counter])
    {
        checker = false;
        break;
    }
    else checker = true;

}
if (checker)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}


//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double X, Y, Z, U, V, W;

Console.WriteLine("введите три числа (координаты первой точки)");
X = double.Parse(Console.ReadLine());
Y = double.Parse(Console.ReadLine());
Z = double.Parse(Console.ReadLine());

Console.WriteLine("введите три числа (координаты второй точки)");
U = double.Parse(Console.ReadLine());
V = double.Parse(Console.ReadLine());
W = double.Parse(Console.ReadLine());

double Length = Math.Sqrt((U - X) * (U - X) + (V - Y) * (V - Y) + (W - Z) * (W - Z));

Console.WriteLine($"расстояние между точками =  {Length}");

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("введите число больше 0");

int N;
N = int.Parse(Console.ReadLine());
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