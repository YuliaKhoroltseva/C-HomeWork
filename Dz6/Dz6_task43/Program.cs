// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Point(double numK1, double numK2, double numB1, double numB2)
{
  if (numK1 == numK2 && numB1 == numB2) Console.Write("Прямые совпадают");
  else if (numK1 == numK2) Console.Write("Прямые параллельны");
  else
  {
    double resX = (numB2 - numB1) / (numK1 - numK2);
    double resY = (numK2 * numB1 - numK1 * numB2 ) / (numK2 - numK1);
    Console.Write($"b1 = {numB1}, k1 = {numK1}, b2 = {numB2}, k2 = {numK2} -> ({resX}; {resX}) ");
  }
}

double GetNum(string text)
{
  Console.Write(text);
  return double.Parse(Console.ReadLine());
}

double k1 = GetNum("Число к1: ");
double k2 = GetNum("Число к2: ");
double b1 = GetNum("Число b1: ");
double b2 = GetNum("Число b2: ");
Point(k1, k2, b1, b2);

