/* Задача 25. Напишите цикл, который принимает на 
вход два числа (A и B) и возводит число A в 
натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

/*double GetNumber(string message) // решение с помощью Math.Pow
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или число меньше 1. Повторите ввод!\n");
        }
    }

    return result;
}

double numberA = GetNumber("Введите число A:");
double numberB = GetNumber("Введите число B:");

double degree = Math.Pow(numberA, numberB);
Console.WriteLine($"Результат возведения числа {numberA} в степень {numberB} равен {degree}");
*/

int GetNumber(string message) // решение циклом
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или число меньше 1. Повторите ввод!\n");
        }
    }

    return result;
}

int numberA = GetNumber("Введите число A:");
int numberB = GetNumber("Введите число B:");
int degreeNum = 1;

int GetDegree(int degreeNum)
{
    for (int i = 1; i <= numberB; i++)
        {
            degreeNum = degreeNum * numberA;
        }
        return degreeNum;
}

int degree = GetDegree(degreeNum);
Console.WriteLine($"{numberA} ^ {numberB} = {degree}");




