/*
Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе

456 - 3
78 - 2
89126 - 5
*/

int NumberDigits(int num)
{
    if (num < 1)
    num = Math.Abs(num); // можно оставить return -1, но это вариант для положительных чисел
    int ind = 0;
    while (num > 0)
    {
        num /= 10;
        ind++;
    }
    return ind;
}

Console.WriteLine("Программа для вывода количества цифр в заданном числе");
Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumberDigits(num));

/*
int CountNumbersN(int n)
{
    if (n == 0)
    return 1;

    int result = 0;
    result = (int)Math.Log10(Math.Abs(n)) + 1;
}
*/