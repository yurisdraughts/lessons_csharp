void ShowQuarter(int n)
{
    if (n < 1 || n > 4)
    {
        Console.WriteLine("Такой четверти не существует!");
    }
    else
    {
        if (n == 1)
        {
            Console.WriteLine("x > 0; y > 0");
        }
        else if (n == 2)
        {
            Console.WriteLine("x < 0; y > 0");
        }
        else if (n == 3)
        {
            Console.WriteLine("x < 0; y < 0");
        }
        else
        {
            Console.WriteLine("x > 0; y < 0");
        }
    }
}

ShowQuarter(0);
ShowQuarter(1);
ShowQuarter(2);
ShowQuarter(3);
ShowQuarter(4);
ShowQuarter(5);