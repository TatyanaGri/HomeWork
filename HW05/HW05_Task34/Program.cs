/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 

1.Определяем массив
2.Выявляем четные числа и подсчитываем их
3.Выводим на экран массив и количество положительных чиисел
*/

int[] FillArray(int array)
{
  int[] arr = new int[array];
  Random rnd = new Random();

  for (int i = 0; i < array; i++)
  {
    arr[i] = rnd.Next(100, 999);
  }
  return arr;
}

int EvenNumber(int[] even)
{
  var count = 0;
  for (int i = 0; i < even.Length; i++)
  {
    if (even[i] % 2 == 0 )
      count++;
  }
  return count;
}

int[] array = FillArray(10);

int count = EvenNumber(array);

Console.WriteLine(string.Join(", ", array));

Console.WriteLine($"В данном массиве находится {count} четных числа.");
