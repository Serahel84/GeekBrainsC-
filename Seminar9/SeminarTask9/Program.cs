//задача 1 Вывести на экран максимальное количество следующих друг за другом 1.

void FillArray(int[] array)
{
    int Counter = 0;
	int MaxCounter = 0;
	for (int i = 0; i < array.Length; i++)
	{ 
		array[i] = new Random().Next(0, 2);
	}
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] == 1)
		{
			Counter++;
		}
		if (i > 0 && array[i - 1] == 1 && array[i] == 0 || i == array.Length - 1)
		{
			if (Counter > MaxCounter)
			{
				MaxCounter = Counter;
			}
			Counter = 0;
		}
		Console.Write($" {array[i]} ");
	}
	Console.WriteLine();
	if (MaxCounter != 1)
	Console.WriteLine($"Number one repeat = {MaxCounter}" );
	else Console.WriteLine($"Number one repeat = 0" );
}

//задача 2 Вывести на экран число, которое формируется элементами массива слева-направо + 1

void PrintNumberElementsArray(int[] array)
{
	int Number = 0;
	for (int i = 0; i < array.Length; i++)
	{
		Number += array[i];
		if (i < array.Length - 1)
		{
			Number *= 10;
		}
	}
	Console.WriteLine(Number + 1);
}

//задача 3 Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. Определите, является ли ваша строка допустимой.

bool СheckString(string Str)
{
	for (int i = 0; i < Str.Length; i++)
	{
		if (Str.Length > 1)
		{
			if (Str[i] == '(' && Str[i + 1] == ')' || Str[i] == '[' && Str[i + 1] == ']' || Str[i] == '{' && Str[i + 1] == '}')
			{
				Str = Str.Remove(i, 2);
				i = - 1;
			}
		}
		else return false;
	}
	if (Str.Length == 0)
	{
		return true;
	}
	else return false;
}

// Задача 4 Даны два положительных целых числа, представленных в виде строк.
//Необходимо получить сумму чисел, которые представлены этими строками. Причем полученная сумма должна быть преобразована в строку.

string SumNumbersChar()
{
    Console.WriteLine("enter two numbers");
    string A = Console.ReadLine();
    string B = Console.ReadLine();
    int a = int.Parse(A);
    int b = int.Parse(B);
    A = (a + b).ToString();
    return A;
}

//--------------------------------------------------------------------------------------------------------------
//задача 1 Вывести на экран максимальное количество следующих друг за другом 1.

int[] Array = new int[7];
FillArray(Array);

//задача 2 Вывести на экран число, которое формируется элементами массива слева-направо + 1

int[] Array2 = new int[7]{ 1,2,1,1,4,4,3 };
PrintNumberElementsArray(Array2);

//задача 3 Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. Определите, является ли ваша строка допустимой.

string Str = "({[()[()]{()}]})";
bool Checker = СheckString(Str);
Console.WriteLine(Checker); 

// Задача 4 Даны два положительных целых числа, представленных в виде строк.
//Необходимо получить сумму чисел, которые представлены этими строками. Причем полученная сумма должна быть преобразована в строку.

string Sum = SumNumbersChar();
Console.WriteLine(Sum);


