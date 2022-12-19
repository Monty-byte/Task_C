Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine() ?? "");

int a1 = number / 10 % 10;

Console.WriteLine($"{number} -> {a1}");