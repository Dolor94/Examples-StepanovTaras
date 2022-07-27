// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();
Console.WriteLine("Программа вычисления функции Аккермана.");
Console.Write("Введите 1-ое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int AckermanFunction(int firstNumber, int secondNumber)
{
  if (firstNumber == 0) return secondNumber + 1;
  else if (firstNumber > 0 && secondNumber == 0) return AckermanFunction(firstNumber - 1, 1);
  else return AckermanFunction(firstNumber - 1, AckermanFunction(firstNumber, secondNumber - 1));
}

int printAckermanFunction = AckermanFunction(firstNumber, secondNumber);

Console.WriteLine($"A({firstNumber},{secondNumber}) = {printAckermanFunction}");