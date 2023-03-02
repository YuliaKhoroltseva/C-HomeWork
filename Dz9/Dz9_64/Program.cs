// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string Sortnum(int numN)
{
  if (numN == 1) return numN.ToString();
  return(numN + ", " + Sortnum(numN - 1));
}

int GetNumArr(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int n = GetNumArr("Значение N: ");
Console.WriteLine($" N = {n} -> {Sortnum(n)}");