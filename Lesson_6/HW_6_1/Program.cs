int[] GenArr(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine();
    return arr;
}

void PrintArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int Zero(int[] arr)
{
    int countZero = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == 0) countZero++;
    }
    return countZero;
}

int[] myArr = GenArr(7);
PrintArr(myArr);
Console.Write("-> ");
int count = Zero(myArr);
Console.Write(count);
