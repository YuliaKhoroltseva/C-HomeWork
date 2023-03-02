// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckPalidrom(int num)
{
    if (num/10000 == num%10 & num/1000%10 == num%100/10)
    {
       Console.WriteLine($"{num} -> да");
    }
    else
    {
        Console.WriteLine($"{num} -> нет");
    }
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int number = GetNum("Введите пятизначное число");

CheckPalidrom(number); 
