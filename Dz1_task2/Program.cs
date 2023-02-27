// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());
if (num1==num2)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (num1>num2)
    {
        Console.Write(num1);
        Console.WriteLine(" = max");
        Console.Write(num2);
        Console.WriteLine(" = min");
        }
    else
    {
        Console.Write(num2);
        Console.WriteLine(" = max");
        Console.Write(num1);
        Console.WriteLine(" = min");
    }
}
