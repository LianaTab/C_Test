/*
Напишите программу, которая выводит массив из 8 
элементов, заполненный нулями и единицами в случайном порядке

[1, 0, 0, 1, 0]

*/

/*
int[] EnterArray(int N)
{
    int[] array = new int[N];
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    int len = array.Length;
    System.Console.Write("[");
    for (int i = 0; i < len; i++)
    {
        if (i == len - 1)
            System.Console.Write($"{array[i]}]");
        else
            System.Console.Write($"{array[i]}, ");
    }
}

System.Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = EnterArray(N);
System.Console.WriteLine("Ваш массив: ");
PrintArray(arr);
*/

int N = getVar();
PrintArray(genArr(N));
void PrintArray(int[] array) {
System.Console.WriteLine($"[{String.Join(",", array)}]\n");   
}


int[] genArr(int N){
    int [] arrNum = new int[N];

    Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(0, 2)) {}
    return arrNum;
}

int getVar(){
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric) {
        Console.Write($"Введите число: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
        if (varValue < 0) {
            isNumeric = false;
        }
    }
    return varValue;
}