/*
Задача 47. Задайте двумерный массив размером m  на n, заполненный 
случайными вещественными числами.
*/
Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");

double[,] array = GetArray(rows, columns, -10, 10);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rnd.Next(minValue, maxValue + 1) + rnd.NextDouble();
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(inArray[i, j], 1)} ");
        }
        Console.WriteLine();
    }
}

PrintArray(array);