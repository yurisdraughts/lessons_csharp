int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

string StringifyArray(int[] array)
{
    string stringArray = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) stringArray += $"{array[i]}, ";
        else stringArray += $"{array[i]}";
    }
    return stringArray;
}

void ReverseArray(int[] array)
{
    int l = array.Length;
    for (int i = 0; i < l / 2; i++)
    {
        int temporary = array[i];
        array[i] = array[l - 1 - i];
        array[l - 1 - i] = temporary;
    }
}

void PrintResult(int[] array)
{
    Console.Write($"[{StringifyArray(array)}] -> ");
    ReverseArray(array);
    Console.WriteLine($"[{StringifyArray(array)}]");
}

int[] a = CreateArray(10, -5, 10);
PrintResult(a);

int[] b = CreateArray(10, -5, 10);
PrintResult(b);

int[] c = CreateArray(10, -5, 10);
PrintResult(c);