// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void SumNum(int num)
{
  int print = num;
  int count = 0;
  int result = 0;
  while (num != 0)
  {
    count = num % 10;
    num = num / 10;
    result = result + count;
  }
  Console.WriteLine(print + " -> " + result);
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int num = GetNum("Введите число: ");

SumNum(num);
