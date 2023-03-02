// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void ListNum(int num)
{
    int count = 2;
    while (count<=num)
    {
       double sqrnum = Math.Pow(count,3);
       Console.Write($", {sqrnum}");
       count++;
    }
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int number = GetNum("Введите число больше 1");

Console.Write($"{number} -> 1");

ListNum(number);
