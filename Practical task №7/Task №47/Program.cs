// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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

double[,] CreateMatrixRndDoubley(int lines, int columns, int minNumber, int maxNumber)
{
    double[,] matrix = new double[lines, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.Next(minNumber, maxNumber) + (rand.NextDouble()), 2);
        }
    }
    return matrix;
}

void PrintMatrixRndDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[ ");
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 6} | ");
            else Console.Write($"{matrix[i, j], 6} ]");
        }
        Console.WriteLine();
    }
}

double[,] matrixRndDoubley = CreateMatrixRndDoubley(lines, columns, minNumber, maxNumber);
PrintMatrixRndDouble(matrixRndDoubley);


// Получаем вот такой результат:

// Задайте параметры двумерного массива!
// Введите количество строк: 4
// Введите количество столбцов: 5
// Задайте диапазон массива (от): -100
// Задайте диапазон массива (до): 100
// [ -21,09 | -61,62 |  11,12 |   86,4 |  37,14 ]
// [  85,36 | -14,03 |  15,92 |  -9,09 | -48,93 ]
// [  86,26 |  99,09 |  82,73 |  60,73 |  76,51 ]
// [  14,94 |  99,27 |     76 | -48,45 | -80,25 ]