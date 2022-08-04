Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = -1 * num; i <= num; i++)
{
    Console.Write(i.ToString() + " ");
}