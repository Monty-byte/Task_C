/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rnd.Next(minValue, maxValue);
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

void GetSumMin(int[,] inArray)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        minRow += inArray[0, i];
    }
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sumRow += inArray[i, j];
        }
        if (sumRow < minRow)
            {
                minRow = sumRow;
                minSumRow = i;
            }
        sumRow = 0;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}.");
}

Console.Clear();
int rows = GetNumberFromUser($"Введите количество строк массива: ", "Ошибка");
int columns = GetNumberFromUser($"Введите количество столбцов массива: ", "Ошибка");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
GetSumMin(array);
