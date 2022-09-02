//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void PrintNumbers(int start, int end)
{
    if (start <= end)
    {
        Console.Write($"{start}");
        if (start < end-1) Console.Write(", ");
        else if (start == end - 1) Console.Write(" и ");

        PrintNumbers(start+1, end);
    }
}

void Main()
{
    Console.Write("Введите первое число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Введите второе число: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Числа от {m} до {n}: ");
    PrintNumbers(m, n);
}

Main();