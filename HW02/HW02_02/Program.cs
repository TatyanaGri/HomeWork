/* Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.Write("Введите число: ");
int DigitNumber = GetNumber();

if (DigitNumber < 100)
{
    Console.WriteLine("Третьего числа нет.");
}
else
{if (DigitNumber > 1000)
    {
    DigitNumber = (DigitNumber / 100) % 10;
    Console.WriteLine($"Третья цифра введеного числа: {DigitNumber}.");
    }
    else 
    {
    DigitNumber = DigitNumber % 10;
    Console.WriteLine($"Третья цифра введеного числа: {DigitNumber}.");   
    }
}