﻿/*
Задача 67: Напишите программу, которая будет принимать на 
вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int SumOfDigits(int num)
{
    if (num == 0) return 0;
    else
    {
        return num % 10 + SumOfDigits(num / 10);
    }
}

Console.Write("Введите число: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine();
int res = SumOfDigits(n);
Console.WriteLine($"Сумма цифр числа {n} = {res}");