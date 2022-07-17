// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Нахождение точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2!");
Console.WriteLine("Введите значения прямых!");
Console.Write("Значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] FindX(double k1, double b1, double k2, double b2)
{
    double x = 0;
    double y = 0;
    if (k1 != k2)
    {
        x = Math.Round((b2 - b1) / (k1 - k2), 2);
        y = Math.Round(k1 * (b2 - b1) / (k1 - k2) + b1, 2);
    }
    return new double[] { x, y };
}
void PrintPoint(double[] point)
{
    if (k1 != k2) Console.Write($"Точка пересечения двух прямых --> ({point[0]}; {point[1]})");
    else Console.Write("Точка пересечения отсутствует, так как прямые парралельны!");
}

double[] answer = FindX(k1, b1, k2, b2);
PrintPoint(answer);