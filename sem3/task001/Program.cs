int FindQuarter(double x, double y)
{
    if (x == 0 || y == 0) return 0;
    else
    {
        if (x > 0)
        {
            if (y > 0) return 1;
            else return 4;
        }
        else
        {
            if (y > 0) return 2;
            else return 3;
        }
    }
}

Console.WriteLine(FindQuarter(4, 7));
Console.WriteLine(FindQuarter(-19, 7));
Console.WriteLine(FindQuarter(-1, -3));
Console.WriteLine(FindQuarter(4, -8));
Console.WriteLine(FindQuarter(0, 5));