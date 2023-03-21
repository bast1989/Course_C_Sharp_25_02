/*
// свой вариант, транспонирует как квадратные, так и прямоугольные матрицы
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

int[,] TransposeArr(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[,] transArr = new int[column, row];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            transArr[j,i] = arr[i,j];
        }        
    }
    
    return transArr;

}


int[,] myArr = GenDoubArr(3, 4, 1, 12);
PrintDoubArr(myArr);
Console.WriteLine();
int[,] tArr = TransposeArr(myArr);
PrintDoubArr(tArr);
*/
// решение семинара

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

void TransposeArr(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (row == column)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < i; j++)
            {
                (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
            }
        }
    }
    else Console.WriteLine("Транспонирование невозможно");
}


int[,] myArr = GenDoubArr(4, 4, 1, 12);
PrintDoubArr(myArr);
Console.WriteLine();
TransposeArr(myArr);
PrintDoubArr(myArr);