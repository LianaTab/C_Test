/*
Напишите программу, которая принимает на вход число 
N и выдаёт произведение чисел от 1 до N.

4 - 24
5 - 120
*/

int N = getVar();
System.Console.WriteLine( multipler(N) );

int multipler(int num)
{
    int outNum = 1;
    
    for (int i = 1; i < num + 1; outNum *= i++)
    {}

    return outNum;
}

int getVar()
{
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric)
    {
        Console.Write($"Введите число: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
       
    }

    return varValue;
}
