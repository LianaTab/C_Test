/*
Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные,
и замените эти элементы на их квадраты.

Изначальный массив:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив:
1 4 49 2
5 9 2 3
64 4 4 4
*/

void PrintArray(int[,] array) // тут есть ошибки, доработать
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i, j]} ");
    }
}

int[,] CreateRandome2DArray(int m, int n, int min, int max)
{
    int[,] array2D = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = random.Next(min, max + 1);
        }
    }
}
int[,] QuadratArray(int[,] oldArray)
{
    for (int i = 0; i < oldArray.GetLength(0); i+= 2)
    {
        for (int j = 0; j < oldArray.GetLength(1); j+= 2)
        {
            oldArray[i, j] *= oldArray[i, j];
        }
    }
    return oldArray;
}

Console.WriteLine("Сгенерированная матрица: ");
int[,] array = CreateRandome2DArray(3, 4, 1, 9);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Новая матрица: ");
PrintArray(QuadratArray(array));