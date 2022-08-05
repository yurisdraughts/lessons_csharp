//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"{a} > {b}.");
}
else if (b > a)
{
    Console.WriteLine($"{b} > {a}.");
}
else
{
    Console.WriteLine($"{a} = {b}.");
}