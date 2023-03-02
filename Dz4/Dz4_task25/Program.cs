// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void GetPow(int num1, int num2)
{
  int result = 1;
  for (int i = 1; i <= num2; i++)
  {
    result = num1 * result;
  }
  Console.WriteLine($"{num1}, {num2} -> {result}");
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int num1 = GetNum("Введите число А ");
int num2 = GetNum("Введите число B ");

GetPow(num1, num2);