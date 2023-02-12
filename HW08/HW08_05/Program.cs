/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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

int[,] InitArray (int row, int col)
{
    int [,] array = new int [row, col];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 100);    
        }
    }
    return array;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SpiralArray (int[,] array)
{
    int col, row;



}

void FullImage
{

    if pic[row, col] == 0) // дальше проверяем условие - если наша позиция = 0, т.е он не закрашен, то мы его красим
    {
        pic[row, col] = 1; //закрашиваем
        FullImage(row-1, col); //наверх. далее в методе мы вызываем сам метод и устанавливаем правило, как мы будем двигаться
        FullImage(row, col-1); //влево
        FullImage(row+1, col); //вниз
        FullImage(row, col+1); //вправо
    }
}


int Row = GetNumber("Введите количество строк: ");
int Col = GetNumber("Введите количество столбцов: ");
Console.WriteLine();

int[,] array = InitArray(Row, Col);
PrintArray (array);


