int num = GetNumberFromUser("Введите целое число", "Ошибка ввода!");
int res = GetResult(num);

Console.WriteLine($"{num} -> {res}");

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
            Console.WriteLine(errorMessage);
    }
}

int GetResult(int number)
{
    int result = 0;
    int absNumber = Math.Abs(number);
    while(absNumber > 0)
    {
        result = result + absNumber%10;
        absNumber = absNumber/10;
    }
    return result;
}
