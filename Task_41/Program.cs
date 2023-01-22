/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел
больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2    1, -7, 567, 89, 223 -> 4
*/

Console.WriteLine("Введите цифры через запятую: ");
string input = Console.ReadLine() ?? "";
int result = 0;

Console.Clear();

int[] num = ParseStringToArray(input);
Console.Write($"[{String.Join(", ", num)}] -> ");

int[] ParseStringToArray(string input)
{
    int countNum = GetCountNumInString(input);
    int [] num = new int[countNum];
    int indexNum = 0;
    string substring = string.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ',')
        {
            substring += input[i];
        }
        else
        {
            num[indexNum] = Convert.ToInt32(substring);
            indexNum++;
            substring = string.Empty;
        }
    }
    if (input[input.Length - 1] != ',')
    {
        num[indexNum] = Convert.ToInt32(substring);
    }
    return num;
}

int GetCountNumInString(string input)
{
    int count;
    if (input[input.Length - 1] == ',')
    {
        count = 0;
    }
    else
    {
        count = 1;
    }

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }
    return count;
}



for (int i = 0; i < num.Length; i++)
{
    if (num[i] > 0)
    {
        result++;
    }
}

Console.Write(result);


