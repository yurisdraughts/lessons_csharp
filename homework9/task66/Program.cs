//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Sum(int start, int end)
{
    if (start == end) return end;
    return start + Sum(start+1, end);
}

void Main()
{
    Console.Write("Введите первое число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Введите второе число: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Сумма чисел от {m} до {n} равна {Sum(m, n)}.");
}

Main();