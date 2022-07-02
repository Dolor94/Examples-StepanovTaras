﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

 Console.Write("Введите цифру обозначающую день недели (Подсказка: от 1 до 7): ");
 int day = Convert.ToInt32(Console.ReadLine());
 switch (day)
 {
    case 1: Console.WriteLine($"{day} день недели - это Понедельник, не является выходным днём!"); break;
    case 2: Console.WriteLine($"{day} день недели - это Вторник, не является выходным днём!"); break;
    case 3: Console.WriteLine($"{day} день недели - это Среда, не является выходным днём!"); break;
    case 4: Console.WriteLine($"{day} день недели - это Четверг, не является выходным днём!"); break;
    case 5: Console.WriteLine($"{day} день недели - это Пятница, не является выходным днём!"); break;
    case 6: Console.WriteLine($"{day} день недели - это Суббота, является выходным днём!"); break;
    case 7: Console.WriteLine($"{day} день недели - это Воскресенье, является выходным днём!"); break;
    default: Console.WriteLine("Ошибка, такого дня недели нет!"); break;
 }