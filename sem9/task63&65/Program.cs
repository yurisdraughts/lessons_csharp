int number = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int n)
{
    if (n == 0) return;
    PrintNumbers(n - 1);
    Console.Write($"{n} ");
}

//PrintNumbers(number);

void PrintNumbers2(int start, int end)
{
    if (start > end) return;
    Console.Write($"{start} ");
    PrintNumbers2(start + 1, end);
}

//PrintNumbers2(1, number);
PrintNumbers2(3, number);