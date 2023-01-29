/* 9. Напишите программу, которая выводит случайное число из отрезка [10, 99 ]
и показывает наибольшую цифру цисла 
78 - 8
12 - 2
85 - 8
*/

/*   "Защита от дурака", проверка ввода в консоль верного формата информации.
Первый оператор возвращает boolean
Чтобы в консоль не выводились сообщения об ошибках.

if(int.TryParse(Console.ReadLine(), out int number))
    Console.WriteLine("Прочитали число: " + number);
else
     Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
*/

 int number = new Random().Next(10, 100);

 Console.WriteLine("Сгенерировано число " + number);

 int firstDigit = number / 10;
 int secondDigit = number % 10;

 /* Тернарный оператор:
  Console.WriteLine("Наибольшая цифра в числе " + number + ": " + (firstDigit > secondDigit ? firstDigit : secondDigit));

 */

 int maxDigit = 0;

 if (firstDigit > secondDigit)
    maxDigit = firstDigit;
    else
    maxDigit = secondDigit;

    Console.WriteLine("Наибольшая цифра в числе " + number + ": " + maxDigit);