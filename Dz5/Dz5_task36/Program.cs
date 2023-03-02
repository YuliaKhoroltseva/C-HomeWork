// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SumEl(int[] arr)
{
  int sum = 0;
  int length = arr.Length;
  for (int i = 0; i < length; i++)
  {
    if (i % 2 != 0) sum += arr[i];
  }
  return sum;
}

int[] FillArray(int length)
{
  int[] arr = new int[length];
  for (int i = 0; i <length; i++)
  {
    arr[i] = new Random().Next(0,1000);
  }
    return arr;
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int num = GetNum("Длина массива: ");
int[] array = FillArray(num);
int sumElements = SumEl(array);
Console.Write("[" + String.Join(", ", array) + "]");
Console.Write(" -> " + sumElements);
