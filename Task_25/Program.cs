int numberA = 0, numberB = 0;

Numbers(ref numberA, ref numberB);
double result = PrintABResult(numberA, numberB);
Console.Write($"{numberA}, {numberB} -> {result};");

static void Numbers(ref int numberA, ref int numberB)
{
    numberA = ReadNum("первое число");
    numberB = ReadNum("второе число");
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

static double PrintABResult(int numberA, int numberB)
{
    double result = Math.Pow(numberA, numberB);
    return result;
}