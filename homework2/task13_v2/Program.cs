//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
    int n = number;
    while (n >= 1000) n /= 10;

    int digit = n % 10;
    Console.WriteLine($"{number} -> {digit}");
}
else Console.WriteLine($"{number} -> третьей цифры нет");