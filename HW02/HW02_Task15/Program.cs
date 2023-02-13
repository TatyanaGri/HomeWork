/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.Write("Введите номер дня недели: ");
int NumberDay = GetNumber();

if (NumberDay < 0 | NumberDay > 7)
{
    Console.WriteLine("Неверный номер дня недели.");
}
else 
{
    if (NumberDay == 6 | NumberDay == 7) 
    {
        Console.WriteLine($"Цифра {NumberDay} является номером выходного дня.");
    }
    else 
    {
        Console.WriteLine($"Цифра {NumberDay} является номером рабочего дня.");
    }
}
