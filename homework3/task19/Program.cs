//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//решение через строки

bool IsPalindrome(string str)
{
    int l = str.Length;

    int i = 0;
    while (i <= l / 2)
    {
        if (str[i] != str[(l - 1) - i]) return false;
        i++;
    }
    return true;
}

void PalindromeNumber(int number)
{
    string num = Convert.ToString(number);

    if (number < 10000 || number > 99999) Console.WriteLine($"{number} -> число не является пятизначным!");
    else
    {
        if (IsPalindrome(num)) Console.WriteLine($"{number} -> да, число является палиндромом.");
        else Console.WriteLine($"{number} -> нет, число не является палиндромом.");
    }
}

PalindromeNumber(14212);
PalindromeNumber(12821);
PalindromeNumber(23432);
PalindromeNumber(525);