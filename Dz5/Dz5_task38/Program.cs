// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double Minmax (double[] array, bool yes)
{
  int length = array.Length;
  double minmax = array[0];
  for (int i = 0; i < length; i++)
  {
    if (array[i] > minmax & yes == true || array[i] < minmax & yes == false)
    {
      minmax = array[i];
    }
  }
  return minmax;
}

double GetNumArray(string text)
{
  Console.Write(text);
  return double.Parse(Console.ReadLine()!);
}

double[] FillArray(int number)
{
  double[] arr = new double[number];
  for (int i = 0; i < number; i++)
  {
    arr[i] = new Random().Next(0,1000);
  }
  return arr;
}

int GetNumLength(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine()!);
}

int num = GetNumLength("Из скольки элементов состоит массив?: ");
double[] array = FillArray(num);
Console.Write("[" + String.Join(" ; ", array) + "]");
double maxElements = Minmax(array, true);
double minElements = Minmax(array, false);
Console.Write(" -> " + maxElements + " - " + minElements + " = " + (maxElements - minElements));

