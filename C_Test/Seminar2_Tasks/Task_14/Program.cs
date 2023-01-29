/*
Напишите программу, которая принимает на вход число и проверяет, кратно
ли оно одновременно 7 и 23

14 - нет
46 - нет
161 - да
*/


Console.WriteLine("Пожалуйста, введите число");
int num = int.Parse(Console.ReadLine());


if (num == 0)
{
System.Console.WriteLine("Число является нулём");
return;
}

/*
int firstTask = (num % 7);
int secondTask = (num % 23);

if (firstTask == 0 && secondTask == 0)
Console.WriteLine("Число кратно 7 и 23");

else
Console.WriteLine("Введённое число НЕ кратно 7 и 23");

*/

if (num % 7 == 0 && num % 23 == 0)
    Console.WriteLine("Число кратно 7 и 23");

else
    Console.WriteLine("Введённое число НЕ кратно 7 и 23");

