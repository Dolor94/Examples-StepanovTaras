// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write ("Введите первое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите второе число: ");
double number2 = Convert.ToDouble(Console.ReadLine());
double max_number = number1;
double min_number = number2;

if (number2 > number1)
{
    max_number = number2;
    min_number = number1;
}
Console.WriteLine("Наибольшим числом является число: " + (max_number));
Console.WriteLine("Наименьшим числом является число: " + (min_number));