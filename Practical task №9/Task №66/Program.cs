// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Программа находит сумму чисел в промежутке от M до N.");
Console.Write("Введите число M: ");
int userStartNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int userFinishNumber = Convert.ToInt32(Console.ReadLine());
int sumNumbers = 0;
int startNumber = userStartNumber;
int finishNumber = userFinishNumber;

if (startNumber > finishNumber)
{
    startNumber = finishNumber;
    finishNumber = userStartNumber;
}

void AmountBetweenNumbers(int startNumber, int finishNumber, int sumNumbers)
{
    sumNumbers += finishNumber;
    if (finishNumber <= startNumber)
    {
        Console.WriteLine($"Сумма чисел в промежутке от {userStartNumber} до {userFinishNumber} = {sumNumbers}.");
        return;
    }
    AmountBetweenNumbers(startNumber, finishNumber-1, sumNumbers);
}
AmountBetweenNumbers(startNumber, finishNumber, sumNumbers);