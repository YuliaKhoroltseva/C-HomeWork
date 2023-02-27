// Напишите программу, которая на вход принимает число и выдает, является ли оно четным

Console.WriteLine("Введите целое число");
int number= int.Parse(Console.ReadLine());
int checknum = number % 2;
if (checknum == 0)
{
    Console.WriteLine("Число четное");
}
else
{
     Console.WriteLine("Число нечетное");
}