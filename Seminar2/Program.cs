/*Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому.
Если число 2 не кратно числу 1,
то программа выводит остаток от деления.

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else Console.WriteLine($"Первое число не кратно второму, остаток от деления равен {a%b}");

int randomNumber = new Random().Next(100, 1000);
Console.WriteLine("Случайное число " + randomNumber);
randomNumber = (randomNumber%10) + (randomNumber/100)*10;
Console.WriteLine("Нужное число " + randomNumber);

/*Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23.
int A = int.Parse(Console.ReadLine());
if (A % 7 == 0 && A % 23 == 0)
{
    Console.WriteLine("Да, число кратно и 7, и 23");
}
else 
{
    Console.WriteLine("Нет, число не кратно ");
}

Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a*a == b || b*b == a)
{
    Console.WriteLine("Да, квадрат одного числа кратен другому числу");
}
else 
{
    Console.WriteLine("Нет, условие не выполняется");
}
*/
/*
int rN = 1176843217;
Console.WriteLine(rN);
int i = rN;
int Reg = 0;
int Rev = 0;
bool trig = 0;
while (i != 0)
{
    i = i / 10;
    Reg++;
}
Console.WriteLine(Reg);

while (Reg != 0)
{
    i = rN % 10;
    if (trig = 0)
    {
        while ()
    } 
    Rev = i * ;
    Reg--;
}
*/

int randomNumber = new Random().Next(1, 10000000);
Console.WriteLine($"Рандомное число {randomNumber}");
int number = 0;
while ((randomNumber / 10) > 0)
{
    number = number*10 + (randomNumber % 10);
    Console.WriteLine(number);
    randomNumber = randomNumber/10;   
}
number = number*10 + randomNumber;
Console.WriteLine(number);

int a = 1535658967;
int b;
int  c = 0;
while (a != 0)
{
    b = a;
    b = b % 10;
    a = a / 10;
    Console.Write(b);
}


