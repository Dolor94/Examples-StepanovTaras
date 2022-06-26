//Дополнительные задачи
// Задача 7: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int last_digit = number % 10;
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Ошибка, введите трёхзначное число!");
    return;
}
else
{
    Console.WriteLine("Последняя цифра вашего числа: " + last_digit);
}