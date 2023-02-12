/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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

int Acerman (int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Acerman(m - 1, 1);
    else return Acerman(m - 1, Acerman(m, n - 1));
}

int m = GetNumber("Введите число M: ");
int n = GetNumber("Введите число N: ");
int Acm = Acerman (m, n);
Console.Write($"Функция Аккермана = {Acm} ");