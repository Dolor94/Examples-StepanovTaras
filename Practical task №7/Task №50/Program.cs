// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("Задайте параметры двумерного массива!");
Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте диапазон массива (от): ");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте диапазон массива (до): ");
int maxNumber = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int lines, int columns, int minNumber, int maxNumber)
{
    int[,] matrix = new int[lines, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(minNumber, maxNumber);
        }
    }
    return matrix;
}

void PrintMatrixRndInt(int[,] matrix)
{
    Console.WriteLine();
    Console.WriteLine("[Двумерный массив задан]");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 6}   |");
            else Console.Write($"{matrix[i, j], 6}   ]");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] matrixRndInt = CreateMatrixRndInt(lines, columns, minNumber, maxNumber);

PrintMatrixRndInt(matrixRndInt);
Console.WriteLine("Задайте позицию элемента, который хотите найти!");

Console.Write("Введите номер строки: ");
int userLine = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int userColumn = Convert.ToInt32(Console.ReadLine());

void FindUserElement(int[,] matrix)
{ 
    for (int i = 0; i <= matrix.GetLength(0); i++)
    {
        for (int j = 0; j <= matrix.GetLength(1); j++)
        {
            if (i == userLine | j == userColumn)
            {
                Console.WriteLine($"Элемент на позиции: [строка {userLine} - столбец {userColumn}] = {matrix[userLine-1,userColumn-1]}");
            }
            else if (userLine < 0 | userLine > matrix.GetLength(0)
            | userColumn < 0 | userColumn > matrix.GetLength(1))
            {
                Console.WriteLine ($"Элемента на позиции: [строка {userLine} - столбец {userColumn}] не существует!");
                break;
            }
        }
    }
}
FindUserElement(matrixRndInt);