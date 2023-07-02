// Программа 1

Console.WriteLine("введите два числа");
int a, b;

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("да");
}
else {Console.WriteLine("нет");}

// программа 2

Console.WriteLine("введите число");

a;
a = int.Parse(Console.ReadLine());

switch (a)
{
    case 1: Console.WriteLine("понедельник");
    break;

    case 2: Console.WriteLine("вторник");
    break;

    case 3: Console.WriteLine("среда");
    break;

    case 4: Console.WriteLine("четверг");
    break;

    case 5: Console.WriteLine("пятница");
    break;

    case 6: Console.WriteLine("суббота");
    break;

    case 7: Console.WriteLine("воскресение");
    break;

    default: Console.WriteLine("нет такого дня");
    break;
}
if (a == 1)
{
    Console.WriteLine("понедельник");
}
else if (a == 2)
{
    Console.WriteLine("вторник");
}
else if (a == 3)
{
    Console.WriteLine("среда");
}
else if (a == 4)
{
    Console.WriteLine("четверг");
}
else if (a == 5)
{
    Console.WriteLine("пятница");
}
else if (a == 6)
{
    Console.WriteLine("суббота");
}
else if (a == 7)
{
    Console.WriteLine("воскресение");
}
else Console.WriteLine("нет такого дня");

// программа 3

Console.WriteLine("введите трехзначное число");

a = int.Parse(Console.ReadLine());

if (a > 99 && a < 1000)
{
    b = a % 10;

Console.WriteLine($"последняя цифра числа =  {b}");

}
else Console.WriteLine("число неверное");


// программа 4

a = int.Parse(Console.ReadLine());
b = -a;

while (b <= a)
{
  Console.WriteLine(b);  
  b++;
}