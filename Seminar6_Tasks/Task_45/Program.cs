/*
Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.
*/

int[] CopyArray(int[] inpArr) {
    int[] result = new int[inpArr.Length];
    for(int i = 0; i < result.Length; i++) {
        result[i] = inpArr[i];
    }
    return result;
}
int[] GenerateArray(int array_Size) {
    int[] result = new int[array_Size];
    Random tmp = new Random();
    for(int i = 0; i < array_Size; i++) {
        result[i] = tmp.Next(100, 1000);
    }
    return result;

}
void printArr(int[] nums) {
    System.Console.Write($"{String.Join(" ", nums)}\n");

}

System.Console.WriteLine("Введите размер массива");
int input = 0;
int.TryParse(Console.ReadLine(), out input);
int[] arr1 = GenerateArray(input);
System.Console.WriteLine("Исходный массив: ");
printArr(arr1);
int[] copy = CopyArray(arr1);
System.Console.WriteLine("Копия массива: ");
printArr(copy);