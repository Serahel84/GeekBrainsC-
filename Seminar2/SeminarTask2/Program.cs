//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("введите трехзначное число");
int a = int.Parse(Console.ReadLine());

int c = a / 10 % 10;
if (a > 99 && a < 1000)
{
Console.WriteLine(c);
}
else Console.WriteLine("число не трехзначное");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("введите трехзначное число");
a = int.Parse(Console.ReadLine());

if (a < 100)
{
    Console.WriteLine("третьей цифры нет");
}
while (a > 99)
{
    if (a < 1000)
    {
        c = a % 10;
        Console.WriteLine(c);
        break;
    }
    a = a / 10;
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("введите цифру дня недели от 1 до 7");
a = int.Parse(Console.ReadLine());

if (a > 0 && a < 8)
{
    if (a > 5)
    {
        Console.WriteLine("да");
    }
    else Console.WriteLine("нет");
}Console.WriteLine("цифра меньше 1 или больше 7, не подходит бро");