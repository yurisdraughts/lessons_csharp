//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double Pow(double A, int B)
{
    double result = 1;
    for (int i = 1; i <= B; i++)
    {
        result *= A;
    }
    return result;
}

void PrintPow(double A, int B)
{
    Console.WriteLine($"{A} в степени {B} равно {Pow(A, B)}.");
}

PrintPow(3, 5); //3 в степени 5 равно 243.
PrintPow(2, 4); //2 в степени 4 равно 16.
PrintPow(1.5, 2); //1,5 в степени 2 равно 2,25.