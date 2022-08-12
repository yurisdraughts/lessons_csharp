//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cubes(int n)
{
    Console.Write($"{n} -> ");

    int i = 1;
    while (i <= n)
    {
        Console.Write($"{Math.Pow(i, 3)}");
        if (i != n) Console.Write(", ");
        else Console.WriteLine("");
        
        i++;
    }
}

Cubes(3);
Cubes(5);