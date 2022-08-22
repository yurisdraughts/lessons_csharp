void MakeBinary()
{
    Console.Write("Введите натуральное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    string binary = string.Empty;
    int n = number;
    while (n > 0)
    {
        binary = $"{n % 2}" + binary;
        n /= 2;
    }

    Console.WriteLine($"{number} -> {binary}");
}

MakeBinary();