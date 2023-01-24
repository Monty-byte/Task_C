/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или уже
указание, что такого элемента нет.
*/
Console.Clear();

int rows = 0, columns = 0, element = 0;

InputUser(ref rows, ref columns, ref element);
int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);



static void InputUser(ref int rows, ref int columns, ref int element)
{
    rows = ReadNum("количество строк");
    columns = ReadNum("количество столбцов");
    element = ReadNum("позицию элемента");
}

static int ReadNum(string Mess)
{
    int num;
    while (true)
    {
        Console.Write($"Введите {Mess}: ");
        try
        {
            num = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода! {exc.Message}");
        }
    }
    return num;
}

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
     Console.WriteLine();
}

bool f = false;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == element) f = true;
    }
}
if (f)
{
    Console.WriteLine($"{element} -> Такое число в массиве есть");
}
else Console.WriteLine($"{element} -> Такого числа в массиве нет");







