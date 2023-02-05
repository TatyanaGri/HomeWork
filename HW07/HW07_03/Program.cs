﻿/*
Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.Write("Ввели не корректное число. Повторите ввод.");
        }
    }
    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    { 
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int countOfRows = GetNumber("Введите количество строк: ");
int countOfColumns = GetNumber("Введите количество столбцов: ");
Console.WriteLine();

int[,] matrix = InitMatrix(countOfRows, countOfColumns);
PrintMatrix(matrix);
Console.WriteLine();

for (int j = 0; j < matrix.GetLength(0); j++)
{
    double sum = 0;
    double value = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum = sum + matrix [i,j]; 
    }
    value = (sum / countOfRows);
    value = Math.Round(value, 1);
    Console.WriteLine($"Среднеарифметическое столбца {j} равно {value} ");
}      
