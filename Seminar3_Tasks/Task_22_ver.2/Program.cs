/*
Напишите программу, которая принимает на вход число N и выдаёт таблицу квадратов 
чисел от 1 до N
5 - 1, 4,9,16,25
2 - 1,4
*/

Console.WriteLine("Программа для вывода таблицы квадратов от 1 до заданного числа ");
Console.WriteLine("Введите число: ");

if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
{
    Console.WriteLine("Введено не целое или отрицательное число");
    return;
}

void powfunc(int N)
{
    int count = 1;
    Console.Write(count* count);
    count++;

    while(count <= N)
    {
        Console.Write(", " + count * count);
        count++;
    }
}
powfunc(N);