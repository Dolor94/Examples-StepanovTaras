// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// 1-ый вариант решение через строку:

// Console.Write("Введите пятнизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string palindrome = Convert.ToString(number);
// int length = palindrome.Length-1;
// for (int index = 0; index < length; index++)
// {
//     if (palindrome[index] == palindrome[length])
//     {
//         Console.WriteLine($"{palindrome[index]} и {palindrome[length]} равны"); length--;
//     }
//     else if (palindrome[index] != palindrome[length])
//     {
//     Console.WriteLine($"{palindrome[index]} и {palindrome[length]} не равны"); 
//     Console.WriteLine($"Число {number} не является палиндромом!"); break;
//     }
// }


// 2-ой вариант решения:

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