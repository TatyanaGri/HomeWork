/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов 
массива.

[3 7 22 2 78] -> 76

*/

int[] FillArray(int array)
{
  int[] arr = new int[array];
  Random rnd = new Random();

  for (int i = 0; i < array; i++)
  {
    arr[i] = rnd.Next(0, 100);
  }
  return arr;
}

int [] array = FillArray(20);
Console.WriteLine(string.Join(", ", array));

int GetDifferenceMaxArray(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
    }
    return max;
}

int GetDifferenceMinArray(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
    }
    return min;
}

int max = GetDifferenceMaxArray(array);
int min = GetDifferenceMinArray(array);
Console.WriteLine($"Max число в массиве равно: {max}");
Console.WriteLine($"Min число в массиве равно: {min}");

int result = max - min;
Console.WriteLine($"Разнца между Max и Min равна: {result}");