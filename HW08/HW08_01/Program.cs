﻿/* 
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
            Console.WriteLine("Ввели не корректное число. Повторите ввод.");
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

int[,] SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = 0;
            for (int x = j + 1; x < matrix.GetLength(1); x++)
            {
                if (matrix[i, j] < matrix[i, x])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, x];
                    matrix[i, x] = temp;
                }
            }
        }
    }
    return matrix;
}

int countOfRows = GetNumber("Введите количество строк: ");
int countOfColumns = GetNumber("Введите количество столбцов: ");
Console.WriteLine();

Console.WriteLine("Неупорядоченная матрица:");
Console.WriteLine();

int[,] matrix = InitMatrix(countOfRows, countOfColumns);
PrintMatrix(matrix);
Console.WriteLine();

Console.WriteLine("Упорядоченная матрица:");
Console.WriteLine();

int[,] sortMatrix = SortMatrix(matrix);
PrintMatrix(sortMatrix);
