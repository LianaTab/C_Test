/*
Напишите программу, которая будет преобразовывать десятичное число в двоисное

45 -- 101101
3 -- 11
2 - 10
*/

System.Console.Write("Введите десятичное число: ");
int num = getVar();

int tmpNum = num;
int count = 0;
while (tmpNum > 0) {
    count++;
    tmpNum /= 2;
}
tmpNum = num;

int[] arrNum = new int[count];
for (int i = arrNum.Length; i > 0; i--) {
    arrNum[i-1] = tmpNum % 2;
    tmpNum /= 2;
}
printArr(num, arrNum);

int getVar(){
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
 void printArr(int num, int[] nums) {
    System.Console.Write($"{num} -> {String.Join("", nums)}\n");
 }