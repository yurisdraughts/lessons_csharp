//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

//зададим метод, создающий массив случайных вещественных чисел заданной длины в заданном диапазоне
double[] CreateArray(int length, double min, double max)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        double random = new Random().NextDouble();
        array[i] = random * (max - min) + min;
    }
    return array;
}

//зададим метод, принимающий массив и возвращающий представление массива в виде строки
string StringifyArray(double[] array)
{
    string stringArray = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) stringArray += $"{array[i]}; ";
        else stringArray += $"{array[i]}]";
    }
    return stringArray;
}

//зададим метод, находящий наибольший эл-т массива
double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

//зададим метод, находящий наименьший эл-т массива
double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

//зададим метод, выводящий на консоль введённый массив, эл-ты с наибольшим и наименьшим значением и их разность
void PrintResult(double[] array)
{
    double max = FindMax(array);
    double min = FindMin(array);
    Console.WriteLine($"{StringifyArray(array)}");
    Console.WriteLine($"{max} - {min} = {max - min}");
}

double[] array = CreateArray(5, 0, 80);
PrintResult(array);