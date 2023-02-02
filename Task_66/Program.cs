/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();
int numberOne = GetNumberFromUser("Введите первое число: ", "Ошибка");
int numberSecond = GetNumberFromUser("Введите второе число: ", "Ошибка");

if (numberOne < numberSecond) Console.Write($"M = {numberOne}; N = {numberSecond} -> '{RecurrSum(numberOne - 1, numberSecond)}'");
else  Console.Write($"M = {numberOne}; N = {numberSecond} -> '{RecurrSum(numberSecond - 1, numberOne)}'");

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

int RecurrSum(int x, int y)
{
    int res = x;
    if (x == y) return 0;
    else
    {
        x++;
        res =  x + RecurrSum(x, y);
        return res;
    }
}

