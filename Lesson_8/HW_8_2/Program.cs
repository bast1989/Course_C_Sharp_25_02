int[,] GenDoubArr(int rang_0, int rang_1, int maiRand, int maxRand)
{
    int[,] arr = new int[rang_0, rang_1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(maiRand, maxRand + 1);
        }
    }
    return arr;
}

void PrintDoubArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] OrderedArr(int[,] arr)
{
    int[] numArr = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            numArr[i] += arr[i, j];
        }
    }
    return numArr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

void MinNum(int[] arr)
{
    int row = 0;
    int minNum = arr[row];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < minNum) 
        {
            minNum = arr[i];
        }
    }
    Console.WriteLine($"Наименьшее число: {minNum}");
}




int[,] myArr = GenDoubArr(3, 4, 1, 3);
PrintDoubArr(myArr);
Console.WriteLine("\n");
int[] newArr = OrderedArr(myArr);
PrintArr(newArr);
Console.WriteLine();
MinNum(newArr);

