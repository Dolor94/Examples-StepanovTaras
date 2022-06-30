// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int rndNum = new Random().Next(100, 1000);
Console.WriteLine(rndNum);

int secondFigure = rndNum % 100 / 10;
Console.WriteLine($"Второй цифрой числа {rndNum} является цифра {secondFigure}");

// либо если мы просим пользователя ввести трёхначное число:
// Console.Write("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int secondFigure = number % 100 / 10;
// if (number < 100 || number >= 1000)
// {
//     Console.WriteLine("Ошибка, введите трёхзначное число!");
//     return;
// }
// else Console.WriteLine($"Второй цифрой числа {number} является цифра {secondFigure}");