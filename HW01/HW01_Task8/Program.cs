/*Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число "); 
string numberStr = Console.ReadLine();  //Вводим данные 
int a = Convert.ToInt32(numberStr);  //Конвертируем в числовой формат
int count = 1; //Задаем счетчик

while (count < a)
{
    if (count % 2 == 0)
    Console.Write(count + ", ");
    count ++;
}

    