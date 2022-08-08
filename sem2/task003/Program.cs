Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 == 0) Console.WriteLine("Невозможно разделить на 0");
else if (num1 % num2 == 0) Console.WriteLine($"{num1}, {num2} -> кратно");
else Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {num1 % num2}");