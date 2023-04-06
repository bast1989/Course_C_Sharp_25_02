
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

int[] CountArr(int[,] arr)
{
    int minNum = arr.Cast<int>().Min();
    int[] containsArr = new int[2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j] == minNum)
            {
                containsArr[0] = i;
                containsArr[1] = j;
            }
        }
    }
    Console.WriteLine($"Минимальное число в массиве {minNum}");
    Console.WriteLine($"Находится в позиции:");
    return containsArr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void DellRCArr(int[,] doubArr, int[] arr)
{
    for (int i = 0; i < doubArr.GetLength(0); i++)
    {
        for (int j = 0; j < doubArr.GetLength(1); j++)
        {
            if(i != arr[0] && j != arr[1])
            {
                Console.Write(doubArr[i, j] + "\t");
            }
        }
        if(i != arr[0])
            {
                Console.WriteLine();
            }
    }
}



int[,] myArr = {{1,4,7,2},{5,9,2,3},{8,4,2,4},{5,2,6,7}};
int[,] myArr_2 = {{4,4,7,2},{5,9,2,3},{8,1,2,4},{5,2,6,7}};
int[,] myArr_3 = GenDoubArr(4, 4, 1, 9);

PrintDoubArr(myArr);
int[] newArr = CountArr(myArr);
Console.WriteLine();
PrintArr(newArr);
Console.WriteLine("\n");
DellRCArr(myArr, newArr);

Console.WriteLine("\n");

PrintDoubArr(myArr_2);
int[] newArr_2 = CountArr(myArr_2);
Console.WriteLine();
PrintArr(newArr_2);
Console.WriteLine("\n");
DellRCArr(myArr_2, newArr_2);

Console.WriteLine("\n");

PrintDoubArr(myArr_3);
int[] newArr_3 = CountArr(myArr_3);
Console.WriteLine();
PrintArr(newArr_3);
Console.WriteLine("\n");
DellRCArr(myArr_3, newArr_3);