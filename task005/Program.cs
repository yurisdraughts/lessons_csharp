Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number < 1000)
{
    int digit = number % 10;
    Console.WriteLine($"Последняя цифра числа {number} равна {digit}.");
}
else
{
    Console.WriteLine("Введённое число не трёхзначное.");
}