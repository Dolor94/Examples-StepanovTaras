// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Решение через встроенную функцию:

// Console.WriteLine("Программа возводящая число А в степень В!");
// Console.Write("Введите число А: ");
// double number = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число В: ");
// double power = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"{number}^{power} = " + Math.Pow(number, power));

// Решение через цикл:

Console.WriteLine("Программа возводящая число А в степень В!");
Console.Write("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int power = Convert.ToInt32(Console.ReadLine());
int newNumber = number;
for (int index = 2; index <= power; index++)
{
    newNumber *= number;
}
Console.WriteLine($"{number}^{power} = {newNumber}");