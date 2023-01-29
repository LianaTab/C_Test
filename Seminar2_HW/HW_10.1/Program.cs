/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите число от 100 до 999: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <=999)
{
int midterm = num % 100;
int second =  midterm / 10;

Console.WriteLine(second); 
}

else

Console.WriteLine("Вы ввели не трёхзначное число");


