/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

/* int a = 2, b = 3, c = 7;
int max = a;
if (a > b && a > c)
    max = a;

if (b > a && b > c)
    max = b;

if (c > a && c > b)
    max = c;

Console.WriteLine(max); */

/* int a = 44, b = 5, c = 78;
int max = a;
if (a > b && a > c)
    max = a;

if (b > a && b > c)
    max = b;

if (c > a && c > b)
    max = c;

Console.WriteLine(max); */

int a = 22, b = 3, c = 9;
int max = 0;

if (a > b && a > c)
    max = a;

if (b > a && b > c)
    max = b;

if (c > a && c > b)
    max = c;

Console.WriteLine(max);