/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Сравнение двух чисел");


Console.WriteLine("Пожалуйста, введите число 1");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите число 2");
int b = int.Parse(Console.ReadLine());

int max = Math.Max(a, b);
int min = Math.Min(a, b);


Console.Write("Наибольшее число: " + max + " Наименьшее число: " + min + " ");