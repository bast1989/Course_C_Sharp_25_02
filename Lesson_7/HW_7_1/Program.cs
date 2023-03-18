
double[,] GenDoubArr(int rang_0, int rang_1, double min, double max)
{
    double[,] arr = new double[rang_0, rang_1];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(min + (new Random().NextDouble() * (max - min)), 1);
        }
    }
    return arr;
}

void PrintDoubArr(double[,] arr)
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



double[,] myArr = GenDoubArr(3, 4, -10, 10);
PrintDoubArr(myArr);

