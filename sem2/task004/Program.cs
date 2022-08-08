Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0) Console.WriteLine($"{num} -> да, число кратно одновременно 7 и 23");
else Console.WriteLine($"{num} -> нет, число не кратно одновременно 7 и 23");