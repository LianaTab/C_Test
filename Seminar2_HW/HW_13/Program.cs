/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/


    Console.WriteLine("Введите число: ");
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    if (num < 100)
    {
    Console.WriteLine("Третьего числа нет");
    }
    
    else
    {

Главное
Магазин
Моё
Каналы
Спорт




25

    do 
    {
        num = num / 10;
    }
    while (num > 999);
    int result = num % 10;
    Console.WriteLine(result);
    }
                
    
          
    