// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число В: ");
double power = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{number}^{power} = " + Math.Pow(number, power));