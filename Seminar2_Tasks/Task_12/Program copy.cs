/*
12. Напишите программу, которая будет принимать на вход два числа и 
выводить, является ли второе число кратным первому.
Если число 2 не кратно числу 1, то программа выводит остаток деления

34,5 - не кратно, остаток 4
16,4 - кратно

*/

Console.WriteLine("Пожалуйста, введите число 1");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите число 2");
int num2 = int.Parse(Console.ReadLine());

/*
if (num1 % num2 == 0)
{
 Console.WriteLine("Число 1 кратно числу 2");   
}
else (result = (num1 % num2)) // ошибка сборки
{
Console.WriteLine("Число 1 НЕ кратно числу 2" + result); 
}

В принципе верно, но не выводит остаток от деления

*/

if (num1 == 0 || num2 == 0)
{
System.Console.WriteLine("Одно из чисел является нулём");
return;
}

int result = num1 % num2;

if (result == 0)
    Console.WriteLine("Число 1 кратно числу 2");

    else
    Console.WriteLine("Число 1 НЕ кратно числу 2, остаток: " + result); 