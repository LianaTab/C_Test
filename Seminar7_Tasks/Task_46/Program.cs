/*
Задайте двумерный массив размером mxn,
заполненный случайными числами.
m = 3, n = 4

1 4 8 19
5 -2 33 -2
77 3 8 1
*/

int[,] createMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j= 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j= 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = createMatrix(3, 4);
PrintMatrix(matrix);

