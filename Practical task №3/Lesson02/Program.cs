// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки 'А' в 3D пространстве:");
Console.Write("x1: "); double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1: "); double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z1: "); double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки 'Б' в 3D пространстве:");
Console.Write("x2: "); double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2: "); double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z2: "); double z2 = Convert.ToDouble(Console.ReadLine());

double coordinate (double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
}
double length =  Math.Round(coordinate(x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine($"Расстояние между точками 'А' и 'Б' равняется: {length}");