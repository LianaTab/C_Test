/*
Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз
встречается элемент входных данных.

Набор данных:
{1, 9, 9, 0, 2, 8, 0, 9} 
Частотный массив:
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
*/

int [,] array = GenerateInt2DArray(4, 4, 0, 20);
Print2DArray(array);

printArr(CountNumArr(array));

int[] CountNumArr(int[,] array)
{
    int maxNum = 0;
    foreach (int num in array) {
        if (maxNum < num)
        {
            maxNum = num;
        }
    }
    int[] outArray = new int[maxNum + 1];
    foreach (int num in array) {
        outArray[num] += 1;
    }
}