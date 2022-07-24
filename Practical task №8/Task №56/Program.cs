// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void SumNumbersLine(int[,] newArray)
{
    int[,] sumNumbers = newArray;
    int[] saveSumLine = new int [sumNumbers.GetLength(0)];
    int minSumNum = int.MaxValue, indexMinLine = 0;
    for (int i = 0; i < sumNumbers.GetLength(0); i++)
    {
        int sumNum = 0;
        for (int j = 0; j < sumNumbers.GetLength(1); j++)
        {
        sumNum += sumNumbers[i,j];
        saveSumLine[i] = sumNum;  
            if (sumNum < minSumNum) 
            {
                minSumNum = sumNum;
                indexMinLine = i;
                Console.WriteLine($"Строка{i+1}");
            }
        }
        Console.WriteLine($"Сумма элементов строки {i+1} = {saveSumLine[i]}");
    }
    Console.WriteLine($"Минимальная сумма элементов находится на строке {indexMinLine+1}");
}

int[,] initialMatrix = CreateMatrixRndInt(lines,columns,minNumber,maxNumber);
PrintMatrixRndInt(initialMatrix);
SumNumbersLine(initialMatrix);