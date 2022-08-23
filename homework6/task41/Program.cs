int[] InputNumbers(int m)
{
    int[] numbers = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write("Введите целое число: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}

string StringifyArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) result += array[i] + ", ";
        else result += array[i];
    }
    return result;
}

int CountPositives(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

void PrintResult(int m)
{
    int[] numbers = InputNumbers(m);
    Console.WriteLine($"{StringifyArray(numbers)} -> {CountPositives(numbers)}");
}

PrintResult(3);