int DigitSum(int number, int sum = 0)
{
    if (number < 10) return sum += number;
    return DigitSum(number / 10, sum + number % 10);
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = DigitSum(number);
Console.WriteLine($"Сумма цифр числа равна {sum}.");
