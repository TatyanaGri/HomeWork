/* Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Number = ReadInt("Введите пятизначное число: ");
int Temp = Number;
int Dig = 0;
int RevNumber = 0;

if (Number < 10000 | Number > 99999) 
{ 
    Console.WriteLine("Число не пятизначное.");
}
else
{    while (Number > 0)
    {
        Dig = Number % 10;
        Number = Number / 10;
        RevNumber = RevNumber * 10 + Dig;
    }
        if (Temp == RevNumber)
        {
            Console.WriteLine("Число палиндром.");
        }
        else
        {
            Console.WriteLine("Число не палиндром.");
        }    
}


