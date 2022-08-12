//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double CalcDistance3d(double[] A, double[] B)
{
    double distance = Math.Sqrt(Math.Pow(A[0] - B[0], 2) + Math.Pow(A[1] - B[1], 2) + Math.Pow(A[2] - B[2], 2));
    return distance;
}

void PrintDistance3d(double[] A, double[] B)
{
    Console.WriteLine($"A({A[0]}, {A[1]}, {A[2]}); B({B[0]}, {B[1]}, {B[2]}) -> {CalcDistance3d(A, B)}");
}

PrintDistance3d(new double[] {3, 6, 8}, new double[] {2, 1, -7});
PrintDistance3d(new double[] {7, -5, 0}, new double[] {1, -1, 9});