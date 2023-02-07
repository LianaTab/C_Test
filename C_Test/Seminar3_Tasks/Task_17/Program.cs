/* Напишите программу, которая принимает на вход координаты точки X и Y, 
причём Х не равен 0 и Y не равен 0 
и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

int CalculateQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    return 1;
    else if (x < 0 && y > 0)
    return 2;
    else if (x < 0 && y < 0)
    return 3;
    else if (x > 0 && y < 0)
    return 4;
    else
    return -1;
}
Console.WriteLine("Программа для вычисления четверти нахождения точки");
Console.WriteLine("Введите координату X: ");
if (!int.TryParse(Console.ReadLine(), out var x)) //Восклицательный знак превращает true в falseю тют если не распарсилось - система выведет сообщение
Console.WriteLine("ВВедено не целое число");

Console.WriteLine("Введите координату Y: ");
if (!int.TryParse(Console.ReadLine(), out var y))
Console.WriteLine("ВВедено не целое число");

if (x == 0 || y == 0)
{
    Console.WriteLine("Точка не должна лежать на оси");
    return;
}

var result = CalculateQuarter(x, y);

if (result != -1) // != это не равно
Console.WriteLine($"Точка {x}, {y} находится в четверти {result}"); // $ это интерполяция, позволяет сформировать шаблон. В фигурных скобках пишутся значения, которые нужно подставить. Заменяет + 
else
Console.WriteLine("Ошибка вычисления, входные данные не верны");


