int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    string printedArray = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) printedArray += $"{array[i]}, ";
        else printedArray += $"{array[i]}]";
    }
    Console.WriteLine(printedArray);
}

string Decline(int number)
{
    int two = number % 100;
    int one = number % 10;
    if (two != 11 && one == 1) return "число";
    if ((two >= 12 && two <= 19) || one >= 5 || one == 0) return "чисел";
    else return "числа";
}

void CountNumbersInRange(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max) count++;
    }
    PrintArray(array);
    Console.WriteLine($"В массиве {count} {Decline(count)} в отрезке [{min}, {max}].");
}

int[] array = CreateArray(123, 0, 123);
CountNumbersInRange(array, 10, 99);