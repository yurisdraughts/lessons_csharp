int[] RandomBinaryArray()
{
    int[] array = new int[8];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray()
{
    int[] array = RandomBinaryArray();
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

PrintArray();
PrintArray();
PrintArray();