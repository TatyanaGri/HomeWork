/* Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double GetNumber(string message)
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
            Console.WriteLine("Ввели не число. Повторите ввод!\n");
        }
    }
    return result;
}

Console.WriteLine("Укажите переменные для двух прямых:");
Console.WriteLine();

double numberB1 = GetNumber("Введите точку b1: ");
double numberK1 = GetNumber("Введите точку k1: ");
Console.WriteLine();

double numberB2 = GetNumber("Введите точку b2: ");
double numberK2 = GetNumber("Введите точку k2: ");
Console.WriteLine();

if (numberB1 == numberB2 && numberK1 == numberK2)
{
  Console.WriteLine("Прямые совпадают");
}
else if ((numberB1 * numberK2 - numberB2 * numberK1) == 0)
{
  Console.WriteLine("Прямые паралельны");
}
else if ((numberB1 * numberK2 + numberB2 * numberK1) == 0)
{
  Console.WriteLine("Прямые перпендикулярны");
}
else
{
double x = (numberB2-numberB1)/(numberK1-numberK2);
double y = (numberK1*(numberB2-numberB1))/(numberK1-numberK2)+numberB1;

Console.WriteLine($"Точки пересечения равны ( {x} : {y} )");
}

/*
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");
*/
