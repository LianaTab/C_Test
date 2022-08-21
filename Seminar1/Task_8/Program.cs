/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.WriteLine("Введите число: ");
int num2 = int.Parse(Console.ReadLine()); 
int count = 1;
int num1 = 1;

/* while(count <= num2)
 
{ */

if((count <= num2) && (num1 % 2 == 0))
{
    Console.WriteLine(num1);
    num1++;

}

else
{
    num1++;
}

