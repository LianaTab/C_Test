/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите число от 100 до 999: ");

int a = Convert.ToInt32(Console.ReadLine());

//int secondnumber(int a)

//{

    int first = a / 100;
    int third = a % 10;
    int second = (first % 100) / 10;

//}
Console.WriteLine(second);
