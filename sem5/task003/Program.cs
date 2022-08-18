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

void IsNumberInArray(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
        {
            Console.WriteLine($"Массив {StringifyArray(array)} содержит число {number}.");
            return;
        }
    }
    Console.WriteLine($"Массив {StringifyArray(array)} не содержит число {number}.");
}

int[] array = CreateArray(5, 0, 345);
IsNumberInArray(-1, array);
IsNumberInArray(45, new int[] {12, 25, 32, 45});