// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int RecAckerman(int numM, int numN)
{
  if (numM == 0) return numN + 1;
  if (numM > 0 && numN == 0) return RecAckerman(numM - 1, 1);
  if (numM > 0 && numN > 0) return RecAckerman(numM - 1, RecAckerman(numM, numN - 1));
  else return 0;
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int m = GetNum("Неотрицательное число m: ");
int n = GetNum("Неотрицательное число n: ");
int result = RecAckerman(m, n);
Console.Write($"m = {m}; n = {n} -> A(m,n) {result}");