Console.Clear();
double[] array = GetArray(5, 1, 100);

double maxNumber = GetMaxNumber(array);
double minNumber = GetMinNumber(array);

Console.Write($"[{String.Join(", ", array)}] -> ");
Console.WriteLine($"{maxNumber - minNumber}");

// Console.WriteLine($"Максимальное число в массиве: {maxNumber}");
// Console.WriteLine($"Минимальное число в массиве: {minNumber}");

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = Convert.ToDouble(new Random().Next(minValue, maxValue));
    }
    return res;
}

double GetMaxNumber(double[] array)
{
    var max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }

    return max;
}

double GetMinNumber(double[] array)
{
    var min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    

    return min;
}