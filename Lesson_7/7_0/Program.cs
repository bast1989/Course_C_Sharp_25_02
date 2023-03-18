int[,] GenDoubArr(int rang_0, int rang_1, int min, int max)
{
    int[,] arr = new int[rang_0, rang_1];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
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



int[,] myArr = GenDoubArr(3, 4, -8, 64);
PrintDoubArr(myArr);

