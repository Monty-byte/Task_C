/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
*/

Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
ArithmeticMean(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] inArray)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
        }
        if (j == inArray.GetLength(1) - 1) Console.Write($"{Math.Round(sum / inArray.GetLength(0), 1)}.");
        else Console.Write($"{Math.Round(sum / inArray.GetLength(0), 1)}; ");
    }
}

