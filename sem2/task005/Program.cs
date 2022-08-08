Console.Write("Введите первое целое число: ");
double a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
double b = Convert.ToInt32(Console.ReadLine());

if (a * a == b || b * b == a) Console.WriteLine($"{a}, {b} -> да, одно из чисел является квадратом другого");
else Console.WriteLine($"{a}, {b} -> нет, ни одно из чисел не является квадратом другого");