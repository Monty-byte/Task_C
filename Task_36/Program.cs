Console.Clear();
int[] array = GetArray(4, -10, 20);
Console.Write($"[{String.Join(", ", array)}] -> ");
Console.WriteLine(sumArray(array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int sumArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2==0) sum= sum + arr[i];
    }
    return sum;
}




