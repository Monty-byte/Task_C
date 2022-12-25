Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine() ?? "");

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


