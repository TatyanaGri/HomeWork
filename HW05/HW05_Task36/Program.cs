/* Задача 36: Задайте одномерный массив, заполненный случайными 
числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

1.Выявляем массив
2.Определяем элементы на нечетных индексах(!) и суммируем их
3.Выводим результат
*/

int[] FillArray(int array)
{
  int[] arr = new int[array];
  Random rnd = new Random();

  for (int i = 0; i < array; i++)
  {
    arr[i] = rnd.Next(-100, 100);
  }
  return arr;
}

int [] array = FillArray(10);
Console.WriteLine(string.Join(", ", array));

int sum = 0;
for (int i = 0; i < array.Length; i ++)
{
  if (i % 2 == 1)
  sum += array[i];
}

Console.WriteLine($"Сумма нечетных позиций массива равна: {sum}");
