//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

//зададим метод, создающий массив случайных 3-значных чисел заданной длины
int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

//зададим метод, принимающий массив и возвращающий представление массива в виде строки
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

//зададим метод, подсчитывающий число чётных чисел в массиве
int CountEvens(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

//зададим метод, выводящий на консоль введённый массив и число чётных чисел в нём
void PrintResult(int[] array)
{
    int count = CountEvens(array);
    Console.WriteLine($"{StringifyArray(array)} -> {CountEvens(array)}.");
}

//вызовем пару методов, создающую случайный массив и выводящую число чётных чисел в нём
int[] array = CreateArray(4);
PrintResult(array);