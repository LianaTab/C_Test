/*
Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно квадратом второго

5, 25 - да
-4, 16 - да
25,5 - да
8, 9 - нет
*/

Console.WriteLine("Пожалуйста, введите число 1");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите число 2");
int num2 = int.Parse(Console.ReadLine());

double sqrtNum1 = Math.Sqrt(num1);
double sqrtNum2 = Math.Sqrt(num2);

System.Console.WriteLine(sqrtNum1 == Math.Abs(num2) || sqrtNum2 == Math.Abs(num1) ? "Да": "Нет");

/* 
double powNum1 = Math.Pow(num1, 2);
double powNum2 = Math.Pow(num2, 2);

System.Console.WriteLine(powNum1 == num2 || powNum2 == num1 ? "Да" : "Нет");

*/

/*

if (num1 = Math.Pow(num2, 2) || num2 = Math.Pow(num1, 2)) // неверно считывается

    Console.WriteLine("Одно число является квадратом второго");

else

    Console.WriteLine("Одно число НЕ является квадратом второго");
*/