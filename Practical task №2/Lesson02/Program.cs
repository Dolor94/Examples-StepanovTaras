// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);
if (numText.Length < 3)
{
    Console.WriteLine("У вашего числа нет третьей цифры");
}
else if (num < 0)
    {
        Console.WriteLine($"Третьей цифрой числа {num} является цифра {numText[3]}");
    }
else Console.WriteLine($"Третьей цифрой числа {num} является цифра {numText[2]}");

// Добавил условие если пользователь введёт отрицательное число.