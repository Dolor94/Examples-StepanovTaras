// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] Array(int size)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((rand.NextDouble() * 100), 2);
    }
    return arr;
}

double[] MinMax(double[] find)
{
    double min = find[0];
    double max = find[1];
    for (int i = 2; i < find.Length; i++)
    {
        if (find[0] > find[1])
        {
            max = find[0];
            min = find[1];
        }
        else if (find[i] > max) max = find[i];
        else if (find[i] < min) min = find[i];
    }
    return new double[] { min, max };
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
}

double DiffMinMax(double[] answer)
{
    double diffMaxMin = Math.Round((answer[1] - answer[0]), 2);
    return diffMaxMin;
}
double[] array = Array(size);
double[] maxMin = MinMax(array);
double answer = DiffMinMax(maxMin);
PrintArray(array);
Console.Write($" --> {answer} (разница между максимальным и минимальным элементов массива)");