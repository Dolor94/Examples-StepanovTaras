// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Программа выщитывающая сумму цифр в заданном числе!");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int number1 = number;
while (number1 > 0)
{
    sum += number1%10;
    number1/=10;
}
Console.WriteLine($"Сумма цифр в числе {number} = " + sum);