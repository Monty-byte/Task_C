int num;

while(true)
{
    Console.Write("Введите пятизначное число: ");

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


int result = num / 1000 / 10; // Нашли первую цифру
int resultTwo = num / 1000 % 10; // Нашли вторую цифру
int resultThree = num % 1000 % 100 / 10; // Нашли предпоследнюю цифру
int resultFour = num % 1000 % 10; // Нашли последнюю цифру

if (result == resultFour)
{
    if (resultTwo == resultThree)
    {
        Console.Write($"{num} -> Да.");
    }
}
else
{
    Console.Write($"{num} -> Нет.");
}