// Написать программу, которая на вход принимает число и выдаёт его квадрат (число, умноженное само на себя)
Console.WriteLine ("Возведение числа в квадрат");
Console.WriteLine("Пожалуйста, введите число и мы возведём его в квадрат");
int number = int.Parse(Console.ReadLine());
//или int number = Convert.ToInt32(Consol.ReadLine());
Console.WriteLine("Введено число " + number);

int result = number * number;
Console.WriteLine("Квадрат числа " + number + " есть число " + result);
