// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте начало диапазона массива (от): ");
int rangeMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте конец диапазона массива (до): ");
int rangeMax = Convert.ToInt32(Console.ReadLine());
int[] Array(int size, int rangeNeg, int rangePoz)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(rangeMin, rangeMax+1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length-1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
}
int[] array = Array(size, rangeMin, rangeMax);

int SumRange(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0)
        {
        sum = sum + array[i];
        }
    }
    return sum;
}
int sumUnevenRange = SumRange(array);
PrintArray(array); 
Console.Write($" --> {sumUnevenRange} (сумма элементов, стоящих на нечётных позициях массива)");