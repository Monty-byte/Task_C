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

int sum = 0;
for (int i = 1; i <= num; i++ )
{
    sum = sum + i;
}
Console.Write($"{num} -> {sum};");


