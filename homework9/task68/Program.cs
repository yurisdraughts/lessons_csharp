//
int Ackermann(int m, int n)
{
    if (m == 0) return n+1;
    else if (m > 0 && n == 0) return Ackermann(m-1, 1);
    return Ackermann(m-1, Ackermann(m, n-1));
}

void Main()
{
    Console.Write("m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("n = ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Write($"A({m}, {n}) = {Ackermann(m, n)}");
}

Main();