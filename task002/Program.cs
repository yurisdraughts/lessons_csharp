Console.Write("Введите первое целое число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a * a == b) 
{
    Console.WriteLine("Да. Первое число является квадратом второго.");
}
else
{
    
    Console.WriteLine("Нет. Первое число не является квадратом второго.");
}