/* Напишите программу, которая по заданному номеру четверти, показывает 
диапазон возможных координат точек этой четверти (x и y)
*/

Console.WriteLine("Программа для вычисления диапазона чисел по номеру четверти");
Console.WriteLine("Введите номер четверти от 1 до 4: ");
//int result = int.Parse(Console.ReadLine());
int result;
while(!Int32.TryParse(Console.ReadLine(), out result))
{
    Console.WriteLine("Вы ввели не число, повторите попытку");
    break;
}


if (result == 1)
    Console.WriteLine ("x: от 0 до + бесконечности; y: от 0 до + бесконечности");
    else if (result == 2)
    Console.WriteLine ("x: от 0 до + бесконечности; y: от 0 до - бесконечности");
    else if (result == 3)
    Console.WriteLine ("x: от 0 до - бесконечности; y: от 0 до - бесконечности");
    else if (result == 4)
    Console.WriteLine ("x: от 0 до - бесконечности; y: от 0 до + бесконечности");
    else
    Console.WriteLine ("Вы ввели неверное число");