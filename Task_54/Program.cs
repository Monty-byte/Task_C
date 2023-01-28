/*
Задача 54.Задайте двумерный массив.Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
     Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
      В итоге получается вот такой массив:
        7 4 2 1
        9 5 3 2
        8 4 4 2
*/




int colCount = 4;
int rowCount = 3;
int[,] arr = GenerateArray(rowCount, colCount);


PrintArray(arr);


int[] row = new int[colCount];
for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j < colCount; j++)
        row[j] = arr[i, j];
    BubbleSort(row);
    Insert(true, i, row, arr);
}

Console.WriteLine();
PrintArray(arr);


void Insert(bool isRow, int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
    {
        if (isRow)
            dest[dim, k] = source[k];
        else
            dest[k, dim] = source[k];
    }
}

int[,] GenerateArray(int t, int i)
{
    int[,] table = new int[t, i];
    Random random = new Random();
    for (int a = 0; a < t; a++)
    {
        for (int b = 0; b < i; b++)
        {
            table[a, b] = random.Next(0, 9);
        }
    }
    return table;
}

void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write(array[a, b] + " ");
        }
        Console.WriteLine();
    }
}

void BubbleSort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] < inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}


