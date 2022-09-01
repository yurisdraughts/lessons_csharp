int Power(int a, int b)
{
    if (b == 1) return a;
    if (b % 2 == 0) return Power(a*a, b/2);
    return a * Power(a, b - 1);
}

Console.Write("Введите основание степени: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите показатель степени: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = Power(a, b);
Console.WriteLine($"Результат равен {result}.");