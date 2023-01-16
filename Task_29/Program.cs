int []  array = GetRandomArray(8, 0, 100);
Console.WriteLine($"[{String.Join(",", array)}]");


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    var rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
    }

    return result;
}
