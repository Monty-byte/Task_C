/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();
int number = GetNumberFromUser($"Введите целое число: ", "Ошибка");


Console.Write($"N = {number} -> '{FindSequence(number, 1)}'");

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


string FindSequence(int start, int end)
{
    if (start == end) return end.ToString();
    else return start + " " + FindSequence(start - 1, end);
}
