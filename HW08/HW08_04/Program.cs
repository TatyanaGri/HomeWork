﻿/* 
Задача 60. 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/

int GetNumber (string message)
{
    int result = 0;
    while(true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
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

int[,,] InitArray (int x, int y, int z)
{
    int [,,] array = new int [x, y, z];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = random.Next(10, 100);    
            }
        }
    }
    return array;
}

void PrintArray (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

int x = GetNumber("Введите x: ");
int y = GetNumber("Введите y: ");
int z = GetNumber("Введите z: ");
Console.WriteLine();

int[,,] array = InitArray (x, y, z);
PrintArray(array);
Console.WriteLine();

проверка на уникальность