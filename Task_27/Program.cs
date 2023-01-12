int num;

while (true)
{
    Console.Write("Введите целое число: ");
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

//int result = Convert.ToString(num).Sum(c => c - '0');

int result = 0;
int numb = num;
while (numb != 0)
{
    result += numb % 10;
    numb /= 10;
}

Console.Write($"{num} -> {result};");
