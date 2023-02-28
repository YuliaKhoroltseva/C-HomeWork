// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли  этот день выходным

Console.WriteLine("Введите номер дня недели от 1 до 7");
int num = int.Parse(Console.ReadLine());
if (num>0 & num <8)
{
    if (num<6)
    {
        Console.WriteLine($"{num} -> нет");
    }
    else
    {
        Console.WriteLine($"{num} -> да");
    }
}
else
{
    Console.WriteLine("Вы ввели неверное число, попробуйте еще раз!");
}