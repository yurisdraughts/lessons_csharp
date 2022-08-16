//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int DigitSum(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

void PrintDigitSum(int number)
{
    Console.WriteLine($"Сумма цифр числа {number} равна {DigitSum(number)}.");
}

PrintDigitSum(452);
PrintDigitSum(82);
PrintDigitSum(9012);
PrintDigitSum(0);