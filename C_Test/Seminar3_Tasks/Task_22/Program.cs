/*
Напишите программу, которая принимает на вход число N и выдаёт таблицу квадратов 
чисел от 1 до N
5 - 1, 4,9,16,25
2 - 1,4
*/

Console.WriteLine("Программа для вывода таблицы квадратов от 1 до заданного числа ");
Console.WriteLine("Введите число: ");
int.TryParse(Console.ReadLine(), out int x);
double Func(int x)
{
    return Math.Pow(x, 2);
}

int i = 1;

while(i <= x)
{
    Console.Write(Func(i));
    if (i<x)
    Console.Write(", ");
    i++;
}

