/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите число от 100 до 999: ");

int a = Convert.ToInt32(Console.ReadLine());

    int midterm = a % 100;
    int second =  midterm / 10;

Console.WriteLine(second);
