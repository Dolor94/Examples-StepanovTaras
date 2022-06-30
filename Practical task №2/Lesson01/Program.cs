// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int rndNum = new Random().Next(100, 1000);
Console.WriteLine(rndNum);

int firstStage = rndNum % 100;
int secondStage = firstStage / 10;
Console.WriteLine($"Второй цифрой числа {rndNum} является цифра {secondStage}");