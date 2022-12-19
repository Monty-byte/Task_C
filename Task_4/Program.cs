Console.Write("Введите первое число: ");
int number_one = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе число: ");
int number_two = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите третье число: ");
int number_three = int.Parse(Console.ReadLine() ?? "");

int max = Math.Max(number_one, Math.Max(number_two, number_three));

Console.Write($"{number_one}, {number_two}, {number_three} -> {max};");



