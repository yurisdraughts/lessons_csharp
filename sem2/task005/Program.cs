Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());

if (a * a == b || b * b == a) Console.WriteLine($"{a}; {b} -> да, одно из чисел является квадратом другого");
else Console.WriteLine($"{a}; {b} -> нет, ни одно из чисел не является квадратом другого");