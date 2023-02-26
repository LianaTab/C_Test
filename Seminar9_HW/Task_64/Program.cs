/*
Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью 
рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void PrintNumber(int num)
{
	if (num == 1)
	{
		Console.WriteLine($"{num}");
	}
	else
	{
		Console.Write($"{num}, ");
		PrintNumber(num - 1);
	}
}

int GetNumber()
{  
    Console.Write($"Введите значение N =  ");
    int.TryParse(Console.ReadLine(), out int num);
    while (num <= 0)
    {
        Console.WriteLine("Число меньше или равно 0, программа не может быть выполнена. Введите число от 1 до N: ");
        int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

Console.WriteLine("Программа для вывода всех натуральных числел от N до 1.\n");
PrintNumber(GetNumber());