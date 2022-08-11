void Squares(int n)
{
    Console.Write($"{n} -> ");

    int i = 1;
    while (i < n)
    {
        Console.Write($"{i * i}, ");
        i++;
    }

    Console.WriteLine($"{n * n}.");
}

Squares(5);
Squares(2);