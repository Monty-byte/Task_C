Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine()); //  Преобразует строковое представление числа с указанным основанием системы счисления в эквивалентное ему 32-битовое целое число со знаком.

string numStr = Convert.ToString(number);

int numDigit = numStr.Length;

if (numDigit > 2)
{
    Console.WriteLine($"{number} -> {numStr[2]}");
}
else
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}

