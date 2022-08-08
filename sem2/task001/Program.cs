int number = new Random().Next(10, 100); //случайное число в диапазоне [10; 100)
int digit1 = number / 10;
int digit2 = number % 10;
if (digit1 > digit2) Console.WriteLine($"{number}, {digit1}");
else Console.WriteLine($"{number}, {digit2}");