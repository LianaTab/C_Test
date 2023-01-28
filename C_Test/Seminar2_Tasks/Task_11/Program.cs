/*
11. Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа
*/

int number = new Random().Next(100, 1000);

 Console.WriteLine("Сгенерировано число " + number);

 int firstDigit = number / 100;
 int thirdDigit = number % 10;

Console.WriteLine("Получилось число: " + firstDigit + thirdDigit);


// Или через доп переменную result