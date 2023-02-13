/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] MatrixScalar (int[,] matrixA, int[,] matrixB, int[,] matrixC)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("Умножение матриц невозможно!");
    }
    
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            //matrixC [i, j] = 0;

            for (int x = 0; x < matrixB.GetLength(1); x++)
            {
                matrixC [i, j] += matrixA [i, x] * matrixB [x, j];
            }
        }
    }
    return matrixC;
}

int countFirstRow = GetNumber("Введите количество строк A матрицы: ");
int countFirstCol = GetNumber("Введите количество столбцов A матрицы: ");
Console.WriteLine();

int[,] matrixA = InitMatrix(countFirstRow, countFirstCol);
PrintMatrix(matrixA);
Console.WriteLine();

int countSecondRow = GetNumber("Введите количество строк B матрицы: ");
int countSecondCol = GetNumber("Введите количество столбцов B матрицы: ");
Console.WriteLine();

int[,] matrixB = InitMatrix(countSecondRow, countSecondCol);
PrintMatrix(matrixB);
Console.WriteLine();

int[,] matrixC = new int [countFirstRow, countSecondCol];
MatrixScalar (matrixA, matrixB, matrixC);
Console.WriteLine($"Произведение матриц A и B равно: ");
PrintMatrix(matrixC);