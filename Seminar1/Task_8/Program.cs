﻿/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.WriteLine("Введите число: ");
int num2 = int.Parse(Console.ReadLine()); 
int num1 = 1;

for (int i = num1; i <= num2; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " ");
    }
}



