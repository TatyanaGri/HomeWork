/* 
Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7

*/


int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод.");
        }
    }
    return result;
}

void FullArray(int[,] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        } 
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int СheckElement (int [,] array)
{
    int element = 0;
    int indexi = GetNumber("Введите индекc i строки для поиска элемента: ");
    int indexj = GetNumber("Введите индекc j столбца для поиска элемента: ");
    Console.WriteLine();
    
    if(indexi < 0 | indexi > array.GetLength(0) & indexj < 0 | indexj > array.GetLength(1))
    {   
        Console.WriteLine("Данного индекса не существует");
    }
    else
    {
        element = array[indexi, indexj];
        Console.WriteLine($"Значение элемента {indexi} индекса строки и {indexj} индекса столбца равно: {element}");
    }
    return element;
}

int rows = GetNumber("Введите количество строк: ");
int columns = GetNumber("Введите количество столбцов: ");
Console.WriteLine();

int[,] array = new int[rows, columns];
FullArray(array);
PrintArray(array);
Console.WriteLine();

int element = СheckElement (array);
