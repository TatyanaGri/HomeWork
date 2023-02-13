/* Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

/*
1. Метод к-й получает число
2. Проверка числа на трехзначность
3. Выводим вторую цифру */

int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.Write("Напишите трехзначное число: ");
int SecondDigitNumber = GetNumber();

if (SecondDigitNumber < 100 || SecondDigitNumber > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число.");
}
else
{
    int NumberDel = SecondDigitNumber / 10 % 10;
    Console.WriteLine($"Вторая цифра введеного числа: {NumberDel}.");
}

