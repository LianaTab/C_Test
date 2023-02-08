/* Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 2D пространстве
А (3,6), В (2, 1) -- 5,09
А (7, -5), В (1, -1) -- 7,21
AB = √((xb - xa)2 + (yb - ya)2)

*/

Console.WriteLine("Поиск расстояния между точками координат");

int xa, ya, xb, yb;

Console.WriteLine("Введите координату X точки A: ");
while(!int.TryParse(Console.ReadLine(), out xa))
{
    Console.WriteLine("Введен неверный параметр");
}

Console.WriteLine("Введите координату Y точки A: ");
while(!int.TryParse(Console.ReadLine(), out ya))
{
    Console.WriteLine("Введен неверный параметр");
}

Console.WriteLine("Введите координату X точки B: ");
while(!int.TryParse(Console.ReadLine(), out xb))
{
    Console.WriteLine("Введен неверный параметр");
}
Console.WriteLine("Введите координату Y точки B: ");
while(!int.TryParse(Console.ReadLine(), out yb))
{
    Console.WriteLine("Введен неверный параметр");
}

double Distance(double xa, double ya, double xb, double yb)
{
    double result = Math.Sqrt(Math.Pow((xb-xa), 2) + Math.Pow((yb - ya), 2));
    return result;
}

double res = Distance(xa, ya, xb, yb);
Console.WriteLine($"Расстояние между двумя точками - {res}");