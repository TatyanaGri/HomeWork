/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Write("Введите первое число "); 
string numberStr1 = Console.ReadLine();  //Вводим данные 
int a = Convert.ToInt32(numberStr1);  //Конвертируем в числовой формат

Console.Write("Введите второе число "); 
string numberStr2 = Console.ReadLine();  //Вводим данные 
int b = Convert.ToInt32(numberStr2);  //Конвертируем в числовой формат

if (a > b)
{
    Console.WriteLine($"min = {b}, max = {a}");
}
else 
{
    Console.WriteLine($"min = {a}, max = {b}");
}
