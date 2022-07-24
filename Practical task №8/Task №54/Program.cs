// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortingMaxMinLine(int[,] newArray)
{
    Console.WriteLine("...сортировка элементов строк по убыванию...");
    int[,] sortingMaxMin = newArray;
    for (int i = 0; i < sortingMaxMin.GetLength(0); i++)
    {
        for (int j = 0; j < sortingMaxMin.GetLength(1); j++)
        {
            for (int k = j+1; k < sortingMaxMin.GetLength(1); k++)
            {
                if (sortingMaxMin[i,j] < sortingMaxMin[i,k])
                {
                    int temp = sortingMaxMin[i,j];
                    sortingMaxMin[i,j] = sortingMaxMin[i,k];
                    sortingMaxMin[i,k] = temp;
                }
            }
        }
    }
    return sortingMaxMin;
}

int[,] initialMatrix = CreateMatrixRndInt(lines,columns,minNumber,maxNumber);
PrintMatrixRndInt(initialMatrix);
int[,] resultingMatrix = SortingMaxMinLine(initialMatrix);
PrintMatrixRndInt(resultingMatrix);