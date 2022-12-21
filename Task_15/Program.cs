Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine() ?? "");



if (day >= 1 && day <= 5)
{
    Console.WriteLine($"{day} -> Нет");
}
else
{
    Console.WriteLine($"{day} -> Да");
}