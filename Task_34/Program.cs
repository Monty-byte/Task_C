Console.Clear();
int[] array = GetArray(4, 100, 1000);
Console.Write($"[{String.Join(", ", array)}] -> ");
Console.WriteLine(Check(array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int Check(int[] arr)
{
    int kol = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] %2==0) kol++;
    }
    return kol;
}


