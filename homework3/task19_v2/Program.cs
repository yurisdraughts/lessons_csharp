//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//чисто числовое решение

void PalindromeNumber(int n)
{
    if (n < 10000 || n > 99999) Console.WriteLine($"{n} -> число не является пятизначным!");
    else
    {
        if (n % 10 == n / 10000 && (n % 100) / 10 == (n / 1000) % 10)
        {
            Console.WriteLine($"{n} -> да, число является палиндромом.");
        }
        else Console.WriteLine($"{n} -> нет, число не является палиндромом.");
    }
}

PalindromeNumber(14212);
PalindromeNumber(12821);
PalindromeNumber(23432);
PalindromeNumber(525);