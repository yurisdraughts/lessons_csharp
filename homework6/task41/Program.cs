//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

//метод для ввода пользователем целых чисел;
//возвращает массив из m эл-тов
int[] InputNumbers(int m)
{
    int[] numbers = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write("Введите целое число: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}

//метод, превращающий массив в строку для дальнейшего отображения в консоли
string StringifyArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) result += array[i] + ", ";
        else result += array[i];
    }
    return result;
}

//метод, возвращающий число положительных чисел в массиве, переданном в качестве аргумента
int CountPositives(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

//основной метод, принимающий число m вводимых пользователем чисел в качестве аргумента
void PrintResult(int m)
{
    int[] numbers = InputNumbers(m);
    Console.WriteLine($"{StringifyArray(numbers)} -> {CountPositives(numbers)}");
}

PrintResult(3);