Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine() ?? "");

if ( a > b)
{
    Console.Write($"a = {a}; b = {b} -> max = {a};");
}
else
{
    Console.Write($"a = {a}; b = {b} -> max = {b};");
}