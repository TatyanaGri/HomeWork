/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
/* не поняла условие задачи, предположу, что мы задаем число N, выводим 8 элем.
от 1 до числа N, разбивая на два массива по 5 и 3 элем. */

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод!\n");
        }
    }
    return result;
}

int number = GetNumber("Введите число: ");

void FillArray(int[] numArray)
{
    int length = numArray.Length;
    int index = 0;
    while (index < length)
    {
        numArray[index] = new Random().Next(1, number);
        index++;
    }
}

int[] arrayFive = new int[5];
int[] arrayTr = new int[3];

FillArray(arrayFive);
FillArray(arrayTr);

Console.WriteLine("[{0}]", string.Join(", ", arrayFive));
Console.WriteLine("[{0}]", string.Join(", ", arrayTr));


