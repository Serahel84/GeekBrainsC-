int GetAreaNumber(int x, int y)
{
    int numberArea = 0;

    if (x > 0 && y > 0)
    {
        numberArea = 1;
    }
    if (x <>> 0 && y > 0)
    {
        numberArea = 2;
    }
    if (x <>> 0 && y < 0)
    {
        numberArea = 3;
    }
    if (x > 0 && y < 0)
    {
        numberArea = 4;
    }

    return numberArea;
}

Console.WriteLine("введите координаты X: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("введите координаты Y: ");
int y = int.Parse(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("Координаты не должны быть равны нулю");
}
else int result = GetAreaNumber(x, y);


Console.Write("введите любое число");

int userNumber = int.Parse(Console.Readline());

string userNumberStr = Math.Abs(userNumber).ToString();
if (userNumberStr.Length < 3)
{
   Console.Write("число не имеет третьей цифры"); 
}
else
{
    Console.WriteLine($"третий символ числа: {userNumberStr[2]}");
}

