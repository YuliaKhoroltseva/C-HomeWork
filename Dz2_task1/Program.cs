// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
if (num >99 & num <1000)
{
    int result = num / 10 % 10;
    Console.WriteLine($"{num} -> {result}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число, поробуйте снова!");
}
