int Digits(int number)
{
    int result = Math.Abs(number).ToString().Length;
    return result;
}

int Digitsv2 (int number)
{
    int n = number;
    int result = 1;

    while (n > 10)
    {
        n /= 10;
        result++;
    }

    return result;
}

void PrintDigits(int number)
{
    Console.WriteLine($"Число {number} содержит {Digits(number)} цифр.");
}

void PrintDigitsv2(int number)
{
    Console.WriteLine($"Число {number} содержит {Digitsv2(number)} цифр.");
}

PrintDigits(456);
PrintDigitsv2(89126);