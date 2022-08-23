// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//метод для ввода коэффициентов уравнения под номером number;
//возвращает массив с 2-мя коэффициентами
double[] InputCoefficients(int number)
{
    Console.Write($"Введите значение k{number}: ");
    double k = Convert.ToDouble(Console.ReadLine());
    
    Console.Write($"Введите значение b{number}: ");
    double b = Convert.ToDouble(Console.ReadLine());

    double[] coefficients = new double[] {k, b};
    return coefficients;
}

//метод для нахождения точки пересечения;
//принимает 2 массива с коэффициентами уравнений;
//возвращает координаты точки пересечения
double[] FindIntersection(double[] coefficients1, double[] coefficients2)
{
    double k1 = coefficients1[0];
    double b1 = coefficients1[1];

    double k2 = coefficients2[0];
    double b2 = coefficients2[1];

    double x = -1 * ((b1-b2) / (k1-k2));
    double y = k1 * x + b1;
    
    double[] intersection = new double[] {x, y};
    return intersection;
}

//главный метод: принимает на ввод коэффициенты 2-х уравнений,
//проверяет 3 сценария: прямые совпадают, параллельны или пересекаются
//и выводит результат в консоль
void MainMethod()
{
    Console.WriteLine("Две прямые заданы уравнениями y = k1 * x + b1, y = k2 * x + b2.");
    double[] coefficients1 = InputCoefficients(1);
    double[] coefficients2 = InputCoefficients(2);
    if (
        coefficients1[0] == coefficients2[0]
        && coefficients1[1] == coefficients2[1]
    )
    {
        Console.WriteLine("Прямые совпадают.");
    }
    else if (coefficients1[0] == coefficients2[0])
    {
        Console.WriteLine("Прямые параллельны.");
    }
    else
    {
        double[] coordinates = FindIntersection(coefficients1, coefficients2);
        Console.WriteLine($"Прямые пересекаются в точке ({coordinates[0]}; {coordinates[1]}).");
    }
}

MainMethod();