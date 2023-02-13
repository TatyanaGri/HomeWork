/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число ");
string numberStr1 = Console.ReadLine();  //Вводим данные 
int a = Convert.ToInt32(numberStr1);  //Конвертируем в числовой формат
Console.Write("Введите второе число ");
string numberStr2 = Console.ReadLine();  //Вводим данные 
int b = Convert.ToInt32(numberStr2);  //Конвертируем в числовой формат
Console.Write("Введите третье число ");
string numberStr3 = Console.ReadLine();  //Вводим данные 
int c = Convert.ToInt32(numberStr3);  //Конвертируем в числовой формат

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("Максимально число = ");
Console.WriteLine(max);
