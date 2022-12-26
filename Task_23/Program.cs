int num;

while(true)
{
    Console.Write("Введите целое число: ");

    try
    {
        num = int.Parse(Console.ReadLine() ?? "");
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message}");
    }
}



Console.Write($"{num} -> ");

for (int index = 1; index <= num; index++)
{
    int result = (int) Math.Pow(index, 3);
    Console.Write($"{result}");
    if ( index < num)
    {
        Console.Write(", ");
    }
    else
    {
        Console.Write(".");
    }
}


