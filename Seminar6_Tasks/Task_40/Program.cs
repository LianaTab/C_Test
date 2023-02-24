/*
Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон

*/

Console.WriteLine("Введите длину стороны AC");
int AC = getVar();
Console.WriteLine("Введите длину стороны AB");
int AB = getVar();
Console.WriteLine("Введите длину стороны BC");
int BC = getVar();

System.Console.WriteLine($"Данный треугольник {(checkTreangle(AC, AB, BC) ? "" : "не ")}может существовать");

bool checkTreangle(int AC, int AB, int BC) {
    if ((AC < AB+BC) && (AB < AC+BC) && (BC < AB+AC)) {
        return true;
    }
    return false;
}
int getVar() {
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric) {
        Console.Write($"Введите проверяемое число: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
        varValue = Math.Abs(varValue);

        if (varValue < 0) {
            isNumeric = false;
        }
    }
    return varValue;
}