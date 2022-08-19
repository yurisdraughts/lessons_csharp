//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//зададим метод, создающий массив случайных чисел заданной длины в заданном диапазоне
int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
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

//зададим метод, подсчитывающий сумму эл-тов на нечётных позициях
int SumEven(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

//зададим метод, выводящий на консоль введённый массив и сумму эл-тов на нечётных позициях
void PrintResult(int[] array)
{
    Console.WriteLine($"{StringifyArray(array)} -> {SumEven(array)}.");
}

//вызовем пару методов, создающую случайный массив и выводящую сумму эл-тов на нечётных позициях
int[] array = CreateArray(4, -90, 90);
PrintResult(array);