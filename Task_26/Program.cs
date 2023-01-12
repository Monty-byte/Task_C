int num;

while (true)
{
    Console.Write("Введите целое число: ");
    try
    {
        num = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch(Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message}");
    }
}

string NumStr = Convert.ToString(num);
int NumLen = NumStr.Length;

Console.Write($"{num} -> {NumLen};");