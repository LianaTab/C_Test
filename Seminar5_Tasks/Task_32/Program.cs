/*
Задача 32: Напишите программу замены элементов массива: положительные 
элементы замените на соответствующие отрицательные и наоборот.
[-4, -8, 8, 2] -- [4, 8, -8, -2]
*/

void PrintArray(int[] array)
{
    System.Console.Write($"[{String.Join("," , array)}]\n");
}

int [] GenerateArr(int n, int min, int max)
{
    int[] arrNum = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max +1)) {}

    return arrNum; 
}

int[] ReverseSign(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) {

    arr[i] = arr[i] * -1;
    }   
    
    return arr;
}

int[] array = GenerateArr(20, -9, 9);
PrintArray(array);
int[] reversedArray = ReverseSign(array);
PrintArray(reversedArray);