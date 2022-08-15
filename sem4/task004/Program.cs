int[] RandomBinaryArray(int number)
{
    int[] array = new int[number];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int number)
{
    int[] array = RandomBinaryArray(number);
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

PrintArray(8);
PrintArray(8);
PrintArray(8);