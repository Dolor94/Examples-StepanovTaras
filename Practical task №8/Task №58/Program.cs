// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine("Произведём расчёт произведения 1-ой и 2-ой матрицы!");
Console.WriteLine("Задайте параметры первой матрицы!");
Console.Write("Введите количество строк первой матрицы: ");
int linesFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int columnsFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте диапазон чисел первой матрицы (от): ");
int minNumberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте диапазон чисел первой матрицы (до): ");
int maxNumberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте параметры второй матрицы!");
Console.Write("Введите количество строк второй матрицы: ");
int linesSecond = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int columnsSecond = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте диапазон чисел второй матрицы (от): ");
int minNumberSecond = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте диапазон чисел второй матрицы (до): ");
int maxNumberSecond = Convert.ToInt32(Console.ReadLine());

int[,] CreatefirstMatrixRndInt(int linesFirst, int columnsFirst, int minNumberFirst, int maxNumberFirst)
{
    int[,] matrix = new int[linesFirst, columnsFirst];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(minNumberFirst, maxNumberFirst);
        }
    }
    return matrix;
}

int[,] CreateSecondMatrixRndInt(int linesSecond, int columnsSecond, int minNumberSecond, int maxNumberSecond)
{
    int[,] matrix = new int[linesFirst, columnsFirst];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(minNumberSecond, maxNumberSecond);
        }
    }
    return matrix;
}

void PrintMatrixRndInt(int[,] matrix)
{
    Console.WriteLine();
    Console.WriteLine("[Матрица создана]");
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

int[,] createFirstMatrix = CreatefirstMatrixRndInt(linesFirst, columnsFirst, minNumberFirst, maxNumberFirst);
int[,] createSecondMatrix = CreateSecondMatrixRndInt(linesSecond, columnsSecond, minNumberSecond, maxNumberSecond);

int[,] ResultsCompositionMatrix(int[,] createFirstMatrix, int[,] createSecondMatrix)
{
    int[,] compositionFirstSecondMatrix = new int[linesFirst,columnsSecond];
    for (int i = 0; i < compositionFirstSecondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < compositionFirstSecondMatrix.GetLength(1); j++)
        {
            int composition = 0;
            for (int k = 0; k < compositionFirstSecondMatrix.GetLength(1); k++)
            {
                composition += createFirstMatrix[i,k] * createSecondMatrix[k,j];
            }
            compositionFirstSecondMatrix[i,j] = composition;
        }
    }
    return compositionFirstSecondMatrix;
}

int[,] resultsComposititonMatrix = ResultsCompositionMatrix(createFirstMatrix, createSecondMatrix);

PrintMatrixRndInt(createFirstMatrix);
PrintMatrixRndInt(createSecondMatrix);
Console.WriteLine($"...расчёт произведения 1-ой и 2-ой матрицы ...");
PrintMatrixRndInt(resultsComposititonMatrix);