//Дополнительные задачи.
// Задача 7: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трёх значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 | number >= 1000)
{
    Console.WriteLine("Ошибка, введите трёхзначное число");
    return;
}
int last_digit = number % 10;
Console.WriteLine("Последняя цифра вашего числа: " + last_digit);