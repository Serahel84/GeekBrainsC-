//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int CounterRealNumbers (int M)
{
    int Counter =0;
    int Number = 0;
    while (M > 0) 
    {
    Console.WriteLine("введите число");
    Number = int.Parse(Console.ReadLine());
    if(Number > 0)
    {
        Counter++;
    }
    M--;
    }
    return Counter;
}

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9

void IntersectionPoint() 
{
    int b1, b2, k1, k2;
    double x, y;
    Console.WriteLine("введите четыре числа");
    b1 = int.Parse(Console.ReadLine());
    k1 = int.Parse(Console.ReadLine());
    b2 = int.Parse(Console.ReadLine());
    k2 = int.Parse(Console.ReadLine());
    if (k1 == k2)
    {
        Console.WriteLine($"Прямые параллельны");
    }
    else
    {
        x = (-(double)b2 + (double)b1) / (-(double)k1 + (double)k2);
        y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения двух прямых: [{x},{y}]");
    } 
}

//------------------------------------------------------------------------------------

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Counter = CounterRealNumbers(6);
Console.WriteLine($"Введено чисел больше 0 - {Counter} раз");

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9

IntersectionPoint();



