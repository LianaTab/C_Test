/*
Задача 33: Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] - нет;
3; массив [6, 7, 19, 345, 3] - да.

*/

int checkNum = getVar();
int[] chekerNumsArr = generateArr(10, 0, 9);
bool flag = checkArr(checkNum, chekerNumsArr);

System.Console.WriteLine($"Число {checkNum} в массиве {arrToStr(chekerNumsArr)} {(flag ? "" : "не ")}встречается");

int getVar(){
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric) {
        Console.Write($"Введите проверяемое число от 0 до 9: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
        varValue = Math.Abs(varValue);
        if (varValue < 0) {
            isNumeric = false;
        }
    }
    return varValue;
}

    bool checkArr(int checkNum, int[] chekerNumsArr) {
        foreach (var item in chekerNumsArr) {
            if (item == checkNum) {
                return true;
            }
        }
        return false;
    }

    int [] generateArr(int n, int min, int max) {
    int[] arrNum = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max +1)) {}

    return arrNum; 
    }

string arrToStr(int[] nums){
    return $"[{String.Join("," , nums)}]";
}