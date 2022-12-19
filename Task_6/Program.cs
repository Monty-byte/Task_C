Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine() ?? "");

if (number % 2 == 0)
{
    Console.Write($"{number} -> Да;");
}
else
{
    Console.Write($"{number} -> Нет;");
}
