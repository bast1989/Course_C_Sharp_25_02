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

string ContainIndex(int[,] arr, int a, int b)
{
    if(arr.GetLength(0) >= a && arr.GetLength(1) >= b) return $"{a} {b} -> {arr[a - 1, b - 1]}";
    else return $"{a} {b} -> такого числа в массиве нет";
}



int[,] myArr = GenDoubArr(3, 4, -8, 64);
PrintDoubArr(myArr);
Console.WriteLine("Введите позиции элемента в двумерном массиве");
Console.Write("Первая позиция элемента: ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.Write("Вторая позиция элемента: ");
int num_2 = int.Parse(Console.ReadLine()!);
string response = ContainIndex(myArr, num_1, num_2);
Console.WriteLine(response);





