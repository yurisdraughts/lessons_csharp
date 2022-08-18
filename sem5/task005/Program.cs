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
    string stringArray = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) stringArray += $"{array[i]}, ";
        else stringArray += $"{array[i]}]";
    }
    return stringArray;
}

void MultiplyArray(int[] array)
{
    int l = array.Length;
    int[] newArray = new int[(l + 1)/2];

    for (int i = 0; i < l / 2; i++)
    {
        newArray[i] = array[i] * array[l - 1 - i];
    }

    if (l % 2 == 1) newArray[newArray.Length - 1] = array[l / 2];

    Console.WriteLine($"{StringifyArray(array)} -> {StringifyArray(newArray)}");
}

int[] array = CreateArray(5, 0, 10);
MultiplyArray(array);