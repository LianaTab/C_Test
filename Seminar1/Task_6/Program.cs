/* 
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число 
чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число:");
int a = Console.ReadLine();


if (a = a % 2 == 1) 
{

    Console.WriteLine ("Число нечётное");
    Console.Write(a);
}

else
{
    Console.WriteLine("Число чётное");
    Console.Write(a);
}
