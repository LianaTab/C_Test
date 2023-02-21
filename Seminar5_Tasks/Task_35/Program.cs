/*
Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10, 99]
Пример для массива из 5, а не 123 элементов.
[5, 18, 123, 6, 2] -- 1
[1, 2, 3, 6, 2] -- 0
[10, 11, 12, 13, 14] -- 5

*/

int[] CreateArray(int lenth, int randomA, int randomB) {
    Random random = new Random();
    int[] arr = new int[lenth];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(randomA, randomB);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int FindElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

int[] arr = CreateArray(20, 0, 200);
PrintArray(arr);
Console.WriteLine();
int count = FindElements(arr);
Console.WriteLine($"Количество элементов массива, которые лежат в диапазоне [10, 99]: {count} ");