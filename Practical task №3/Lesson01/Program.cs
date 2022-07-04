// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;
int palindrome = 0;
while (temp != 0)
{
    palindrome = palindrome*10 + temp%10;
    temp /= 10;
}
if (number == palindrome) Console.WriteLine($"Число {palindrome} является палиндромом!");
else Console.WriteLine($"Число {palindrome} не является палиндромом!");