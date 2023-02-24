/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи 0 и 1.

Если N = 5 -> 0 1 1 2 3 
Если N = 3 -> 0 1 1 
Если N = 7 -> 0 1 1 2 3 5 8

*/

System.Console.WriteLine("Введите число: ");
int input = 0;
int.TryParse(Console.ReadLine(), out input);

int[] FiboArray(int input) {
    int[] result = new int[input];
    result[0] = 0;
    result[1] = 1;
    for(int i = 2; i < input; i++) {
        result[i] = result[i-1] + result[i-2];
    }
    return result;
}

void printArr(int[] nums) {
    System.Console.Write($"{String.Join(" ", nums)}\n");
}

printArr(FiboArray(input));