/* 
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

void SumElement (int M, int N, int sum)
{
    sum = sum + N;
    if (M >= N)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return; 
    } 
    SumElement (M, N - 1, sum);
}

int M = GetNumber("Введите число M: ");
int N = GetNumber("Введите число N: ");
Console.WriteLine();

SumElement(M, N, 0);
