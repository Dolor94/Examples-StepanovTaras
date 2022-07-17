// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Сколько чисел Вы собираетесь ввести: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] MyArray(int size)
{
    int[] array = new int[size]; 
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
}

int PosNumbers(int[] find)
{
    int positive = 0;
    for (int i = 0; i < find.Length; i++)
    {
        if (find[i] > 0) positive++;
    }
    return positive;
}

int[] userArray = MyArray(size);
int positiveNumbers = PosNumbers(userArray);
PrintArray(userArray);
Console.Write($" --> {positiveNumbers} (количество чисел больше 0)");