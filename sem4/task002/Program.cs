int Digits(int number)
{
    int result = Math.Abs(number).ToString().Length;
    return result;
}

int Digitsv2 (int number)
{
    int n = number;
    int result = 1;

    while (n >= 10)
    {
        n /= 10;
        result++;
    }

    return result;
}

string Decline(int number)
{
    if ((number >= 11 && number <= 19) || number % 10 >= 5) return "цифр";
    else if (number % 10 >= 2 && number % 10 <= 4) return "цифры";
    else return "цифру";
}

void PrintDigits(int number)
{
    Console.WriteLine($"Число {number} содержит {Digits(number)} {Decline(Digits(number))}.");
}

void PrintDigitsv2(int number)
{
    Console.WriteLine($"Число {number} содержит {Digitsv2(number)} {Decline(Digitsv2(number))}.");
}

PrintDigits(7);
PrintDigitsv2(10);
PrintDigits(456);
PrintDigitsv2(89126);