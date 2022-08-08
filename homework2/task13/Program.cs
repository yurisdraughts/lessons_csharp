//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100)
{
    char digit = number.ToString()[2];
    Console.WriteLine($"{number} -> {digit}");
}
else Console.WriteLine($"{number} -> третьей цифры нет");