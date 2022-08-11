double Distance(double[] A, double[] B)
{
    double distance = Math.Sqrt(Math.Pow(A[0] - B[0], 2) + Math.Pow(A[1] - B[1], 2));
    Console.WriteLine("{0:N2}", distance);
    return distance;
}

Distance(new double[] {3, 6}, new double[] {2, 1});
Distance(new double[] {7, -5}, new double[] {1, -1});