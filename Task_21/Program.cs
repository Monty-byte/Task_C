Console.Clear();
int ax = 0, ay = 0, az = 0, bx = 0, by = 0, bz = 0;

InitCoordinatesByUser(ref ax, ref ay, ref az, ref bx, ref by, ref bz);
double result = PrintABResult(ax, ay, az, bx, by, bz);
Console.Write($"A({ax}, {ay}, {az}); B({bx}, {by}, {bz}) -> {Math.Round(result, 2)}");

static void InitCoordinatesByUser(ref int ax, ref int ay, ref int az, ref int bx, ref int by, ref int bz)
{
    ax = ReadNum("x точки A");
    ay = ReadNum("y точки A");
    az = ReadNum("z точки A");
    bx = ReadNum("x точки B");
    by = ReadNum("y точки B");
    bz = ReadNum("z точки B");
}

static int ReadNum(string Mess)
{
    int num;
    while(true)
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

static double PrintABResult(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Sqrt((Math.Pow((bx - ax), 2)) + (Math.Pow((by - ay), 2)) + (Math.Pow((bz - az), 2)));
    return result;
}

