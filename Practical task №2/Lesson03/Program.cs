// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

 Console.Write("Введите цифру обозначающую день недели (Подсказка: от 1 до 7): ");
 int day = Convert.ToInt32(Console.ReadLine());
 switch (day)
 {
    case 1: Console.WriteLine("1-ый день недели - это Понедельник!"); break;
    case 2: Console.WriteLine("2-ой день недели - это Вторник!"); break;
    case 3: Console.WriteLine("3-ий день недели - это Среда!"); break;
    case 4: Console.WriteLine("4-ый день недели - это Четверг!"); break;
    case 5: Console.WriteLine("5-ый день недели - это Пятница!"); break;
    case 6: Console.WriteLine("6-ой день недели - это Суббота, является выходным днём!"); break;
    case 7: Console.WriteLine("7-ой день недели - это Воскресенье, является выходным днём!"); break;
    default: Console.WriteLine("Ошибка, такого дня недели нет!"); break;
 }
    