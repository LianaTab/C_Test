/*
Задача 69: Напишите программу, которая на вход принимает два 
числа A и B, и возводит число А в целую степень B с помощью 
рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int Power(int n, int p) {
    if (p != 0) {
        return (n * Power(n, p - 1));
    }
    return 1;
}
int ReadNumber()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0) {
            return number;
        }
        else Console.WriteLine("Не удалось распознать требуемое число, попробуйте ещё раз");
    }

}
Console.Clear();
Console.Write("Введите основание степени: ");
int n = ReadNumber();
Console.Write("введите показатель степени: ");
int p = ReadNumber();
Console.WriteLine("{0} в {1} степени равно {2}.", n, p, Power(n, p));


/* С учётом отрицательных.

double PowNumbers(double numA, double numB)
{
if (numB == 1)
{
return numA;
}
else if (numB == 0)
{
return 1;
}
else if (numB < 0)
{
return 1 / PowNumbers(numA, Math.Abs(numB));
}
else
{
return numA * PowNumbers(numA, numB - 1);
}
}

double GetNumber()
{
Console.Write($"Введите значение числа: ");
double.TryParse(Console.ReadLine(), out double result);
return result;
}

double numberA = GetNumber();
double numberB = GetNumber();
Console.WriteLine($"Число {numberA} в степени {numberB} = {PowNumbers(numberA, numberB)}");


*/