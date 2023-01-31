/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();

int rows = GetNumberFromUser($"Введите количество строк массива: ", "Ошибка");
int columns = GetNumberFromUser($"Введите количество столбцов массива: ", "Ошибка");

int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

GetArrayRandom(array);
PrintArray(array);

Console.WriteLine();

GetArrayRandom(secondArray);
PrintArray(secondArray);

Console.WriteLine();

if(array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine("Нельзя перемножить");
    return;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i,j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i,j] += array[i,k] * secondArray[k,j];
        }
    }
}

PrintArray(resultArray);

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

void GetArrayRandom(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

