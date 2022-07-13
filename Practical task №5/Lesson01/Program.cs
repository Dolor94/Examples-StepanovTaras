// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] Array(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
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
int[] array = Array(size);

int EvenNumbers(int[] array)
{
    int score = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        score++;
    }
    return score;
}
int sumEvenNumbers = EvenNumbers(array);
PrintArray(array); 
Console.Write($" --> {sumEvenNumbers} (количество чётных чисел в массиве)");