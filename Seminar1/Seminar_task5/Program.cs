// Напишиет программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа
// 456 -> 6 782 -> 2 918->8

Console.WriteLine("Введите число от 100 до 999");

int num = int.Parse(Console.ReadLine());

if (num >= 100 && num <=999)
{
int num3 = num % 10;
Console.WriteLine(num3);
}
else 
{
 Console.WriteLine("Вы ввели неверное число");   
}

