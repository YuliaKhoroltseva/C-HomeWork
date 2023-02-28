// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите целое число");
int num = int.Parse(Console.ReadLine());
int num1 = num;
if (num<0) num1 = -1*num; //если пользователь введет отрицательное число
if ( num1>99 & num1<1000)
{
    int result = num1 % 10;
    Console.WriteLine($"{num} -> {result}");
}
else
{
    if (num1<100)
    {
     Console.WriteLine($"{num} -> третьей цифры нет");
    }
    else
    {
        while (num1>999) 
        {
            num1 = num1 / 10;
        }
        int result = num1 % 10;
        Console.WriteLine($"{num} -> {result}");
    }
}