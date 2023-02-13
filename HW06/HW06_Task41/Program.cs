/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

вводим через один Enter (разбиваем через Split())
*/

Console.WriteLine("Введите числа через пробел: ");
int [] arr = Console.ReadLine().Split(new char []{' '}, StringSplitOptions.RemoveEmptyEntries).Select(number => Convert.ToInt32(number)).ToArray();
/* 
создаем массив; 
split - выводит вводимые элементы в одну строку с нужным разделителем; 
StringSplitOptions.RemoveEmptyEntries - убирает лишние пробелы (при лишних пробелах выскакивала ошибка ввода)
Select - последовательно преобразует каждый элемент 
конвертируем элементы массива в int
*/

int NulArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      if(arr[i] > 0) 
      count = count + 1;
    }
    return count;
}

int result = NulArray(arr);
Console.WriteLine($"Количество чисел больше 0, введенных пользователем равно: {result}");
