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

void ChanStrArr(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int j = 0; j < column; j++)
    {
        (arr[0, j], arr[row - 1, j]) = (arr[row - 1, j], arr[0, j]);
    }

}


int[,] myArr = GenDoubArr(3, 4, 1, 12);
PrintDoubArr(myArr);
ChanStrArr(myArr);
System.Console.WriteLine();
PrintDoubArr(myArr);