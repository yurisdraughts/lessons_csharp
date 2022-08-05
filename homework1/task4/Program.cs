//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите третье число: ");
double c = Convert.ToDouble(Console.ReadLine());

if (a >= b && a >= c)
{
    Console.WriteLine($"{a} самое большое число.");
}
else if (b >= a && b >= c)
{
    Console.WriteLine($"{b} самое большое число.");
}
else
{
    Console.WriteLine($"{c} самое большое число.");
}