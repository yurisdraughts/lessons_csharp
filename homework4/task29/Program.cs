// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// прежположим, что под элементами подразумеваются только целые числа - как в примере
void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

// 1-й вариант: массив введённых пользователем чисел
int[] InputArray8()
{
    int[] array = new int[8];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-е целое число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

// 2-й вариант: массив случайных чисел в диапазоне [0; ceiling)
// или (-ceiling; ceiling) в зависимости от значения 3-го аргумента
int[] RandomArray8(int ceiling, bool includeNegatives)
{
    int[] array = new int[8];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, ceiling);
        if (includeNegatives)
        {
            int n = new Random().Next(0, 2);
            if (n == 0) array[i] *= -1;
        }
    }
    return array;
}

//ВЫЗОВ МЕТОДОВ
PrintArray(InputArray8());

PrintArray(RandomArray8(45678, false));
PrintArray(RandomArray8(2, false));
PrintArray(RandomArray8(33, true));