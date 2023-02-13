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

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + " ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] SpiralArray (int rows, int columns)
{
    int[,] array = new int[rows, columns];
    
    int count = 1;
    int layer = 0;
    if (rows <= columns && rows % 2 == 0) layer = rows / 2; 
    if (rows <= columns && rows % 2 != 0) layer = rows / 2 + 1;  
    if (rows > columns && columns % 2 == 0) layer = columns / 2; 
    if (rows > columns && columns % 2 != 0) layer = columns / 2 + 1; 

    for (int k = 0; k < layer; k++) 
    {
        for (int j = k; j < columns - k - 1; j++)
        {
            array[k, j] = count;
            count++;
            if(count>rows*columns) break;
        }
        
        for (int i = k; i < rows - k - 1; i++) 
        {
            array[i, columns - k - 1] = count;
            count++;
            if(count>rows*columns) break;
        }
        
        for (int j = columns - k - 1; j > k; j--) 
        {
            array[rows - k - 1, j] = count;
            count++;
            if(count>rows*columns) break;
        }
        
        for (int i = rows - k - 1; i > k; i--)  
        {
            array[i, k] = count;
            count++;
            if(count>rows*columns) break;    
        }
    }
    if(rows==columns&&rows%2!=0) array[layer-1,layer-1]=count;
    
    return array;
}

int row = GetNumber("Введите количество строк: ");
int col = GetNumber("Введите количество столбцов: ");
Console.WriteLine();

int[,] array = SpiralArray(row, col);
PrintArray (array);


