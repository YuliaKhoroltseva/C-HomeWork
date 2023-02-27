// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите челое положительное число");
int num = int.Parse(Console.ReadLine());
int count = 2;
if (num>1)
{
    while (count<=num)
    {
        if (count%2 == 0)
        {
            Console.Write(count);
            Console.Write(" ");
        }
        count = count +1;
    }
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}