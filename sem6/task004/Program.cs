string StringifyArray(int[] array)
{
    string stringArray = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) stringArray += $"{array[i]} ";
        else stringArray += $"{array[i]}";
    }
    return stringArray;
}

int[] Fibonacci(int n)
{
    int[] fibs = new int[n];
    fibs[0] = 0;
    fibs[1] = 1;
    for (int i = 2; i < fibs.Length; i++)
    {
        fibs[i] = fibs[i-2] + fibs[i-1];
    }
    return fibs;
}

void PrintResult(int n)
{
    Console.WriteLine($"Если N = {n} -> {StringifyArray(Fibonacci(n))}");
}

PrintResult(5);
PrintResult(3);
PrintResult(7);