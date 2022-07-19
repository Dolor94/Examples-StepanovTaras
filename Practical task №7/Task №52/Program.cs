// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}   |");
            else Console.Write($"{matrix[i, j],5}   ]");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindAverageNumbersColumn(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double averageNumbersColumn = 0.0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            averageNumbersColumn += matrix[i, j];
        }
        Console.WriteLine($"Среднее арифметическое элементов в [столбце {j + 1}] = {Math.Round(averageNumbersColumn / matrix.GetLength(0),2)}");
    }
}

int[,] matrixRndInt = CreateMatrixRndInt(lines, columns, minNumber, maxNumber);
PrintMatrixRndInt(matrixRndInt);
FindAverageNumbersColumn(matrixRndInt);