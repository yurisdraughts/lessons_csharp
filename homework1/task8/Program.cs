﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите положительное число: "); //или для отрицательных программа тоже должна работать?
double n = Convert.ToDouble(Console.ReadLine());

Console.Write($"Все чётные числа от 1 до {n}: ");
int i = 2;
while (i <= n)
{
    Console.Write(i.ToString() + " ");
    i += 2;
}