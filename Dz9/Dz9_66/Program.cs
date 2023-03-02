// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumMN(int numM, int numN)
{
  if (numM == numN) return numM;
  if (numM < numN) return numM + SumMN(numM + 1, numN);
  else return numN + SumMN(numM, numN + 1);
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int m = GetNum("Положительное число M: ");
int n = GetNum("Положительное число N: ");
int result = SumMN(m, n);
Console.Write($"M = {m}; N = {n} -> {result}");