// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintArray(int[] arr)
{
  int length = arr.Length - 1;
  Console.Write("[");
  for (int i = 0; i < length; i++)
  {
    Console.Write(arr[i] + ", ");
  }
  Console.Write(arr[length] + "]");
}

int[] GetArray(int number)
{
  int[] array = new int[number];
  int length = array.Length;
  for (int i = 0; i < length; i++)
  {
    array[i] = new Random().Next(0,100);
  }
  return array;
}

int GetLength(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int num = GetLength("Из скольки элементов состоит массив?: ");
PrintArray(GetArray(num));
