﻿/* Напишите программу, которая принимает на вход координаты точки X и Y, 
причём Х не равен 0 и Y не равен 0 
и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

Console.WriteLine("Программа для вычисления четверти нахождения точки");
Console.WriteLine("Введите координату X");
if (!int.TryParse(Console.ReadLine(), out var x))
Console.WriteLine("Введите координату Y");