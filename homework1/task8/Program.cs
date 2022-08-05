//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
double n = Convert.ToDouble(Console.ReadLine());


if (n >= 2)
{
    Console.Write($"Все чётные числа от 1 до {n}: ");

    int i = 2;
    while (i <= n)
    {
        Console.Write(i.ToString() + " ");
        i += 2;
    }
}
else if (n <= 0)
{
    Console.Write($"Все чётные числа от 1 до {n}: ");
    
    int i = 0;
    while (i >= n)
    {
        Console.Write(i.ToString() + " ");
        i -= 2;
    }
}
else
{
    Console.Write($"Между 1 и {n} нет чётных чисел.");
}