/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();
uint numberOne = GetNumberFromUser("Введите первое число: ", "Ошибка");
uint numberSecond = GetNumberFromUser("Введите второе число: ", "Ошибка");

Console.Write($"m = {numberOne}; n = {numberSecond} -> A(m, n) = {Akk(numberOne, numberSecond)}");


uint GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = uint.TryParse(Console.ReadLine(), out uint userNumber);
        if (isCorrect)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}

uint Akk(uint m, uint n)
{
    if (m == 0) return n + 1;
    else if ((n == 0 && m > 0))
    {
        return Akk(m - 1, 1);
    }
    else return Akk(m - 1, Akk(m, n - 1));
}