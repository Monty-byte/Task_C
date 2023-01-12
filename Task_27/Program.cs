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

int result = Convert.ToString(num).Sum(c => c - '0');

Console.Write($"{num} -> {result};");
