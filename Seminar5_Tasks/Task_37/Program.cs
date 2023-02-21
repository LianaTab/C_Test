/*
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.

[1 2 3 4 5 ] -- 5 8 3
[6 7 3 6] -- 36 21

Тут ошибка при компиляции, разобраться
Unhandled exception. System.IndexOutOfRangeException: 
Index was outside the bounds of the array.
*/

int[] numsArr = generateArr(6, 1, 9);
int outArrLength = numsArr.Length / 2 + numsArr.Length % 2;
int[] outNumsArr = new int[outArrLength];

printArr(numsArr);
for (int i = 0; i < outArrLength; i++) {
    int j = numsArr.Length-i-1;
    if (i < outArrLength -1) {
        outNumsArr[i] = outNumsArr[i] * outNumsArr[j];
    } else {
        outNumsArr[i] = numsArr[i];
    }
}
printArr(outNumsArr);

int [] generateArr(int n, int min, int max) {
    int[] arrNum = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) {}

    return arrNum; 
    }

void printArr(int[] nums) {
    System.Console.Write($"[{String.Join(",", nums)}]\n");
}
