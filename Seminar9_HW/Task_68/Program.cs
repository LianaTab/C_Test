/*
Задача 68: Напишите программу вычисления функции Аккермана с
помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int FunctionAckerman(int m, int n)
{
	if (m == 0)
	{
		return n + 1;
	}
	else if (m > 0 && n == 0)
	{
		return FunctionAckerman(m - 1, 1);
	}
	else if (m > 0 && n > 0)
	{
		return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
	}
	else
	{
		return -1;
	}
}

int GetNumber(string name)
{  
    Console.Write($"Введите значение {name} =  ");
    int.TryParse(Console.ReadLine(), out int num);
    while (num < 0)
    {
        Console.WriteLine("Число меньше 0. Введите натуральное число: ");
        int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

Console.WriteLine("Программа выводит значение функции Аккермана по введённым числам M и N.");
int M = GetNumber("M");
int N = GetNumber("N");
Console.WriteLine($"Значение функции Аккермана для чисел {M} и {N} = {FunctionAckerman(M, N)}");