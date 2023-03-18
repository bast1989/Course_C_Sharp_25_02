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

string ContainDoubArr(int[,] arr, int num)
{
    string text = "";    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] == num)
            {
                text = $"Введенный элемент {num}, результат: [{i}, {j}]";
                goto Found;
            }
            else
            {
                text = $"Введенный элемент {num}, результат: такого элемента нет";
            }
        }
    }
    Found: return text;
}

int[,] myArr = GenDoubArr(3, 3, 1, 9);
PrintDoubArr(myArr);
string containNum = ContainDoubArr(myArr, 6);
Console.WriteLine(containNum);



