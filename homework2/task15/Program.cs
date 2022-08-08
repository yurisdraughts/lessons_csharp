//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7) Console.WriteLine($"{number} -> да, этот день выходной");
else Console.WriteLine($"{number} -> нет, этот день не выходной");