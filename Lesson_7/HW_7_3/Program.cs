int[,] GenDoubArr(int rang_0, int rang_1, int min, int max)
{
    int[,] arr = new int[rang_0, rang_1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
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

double[] MediumDoubArr(int[,] arr, int size, int elem)
{
    double[] medium = new double[elem];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < medium.Length; k++)
            {
                if (k == j) medium[k] += arr[i, j];
            }
        }
    }

    for (int i = 0; i < medium.Length; i++)
    {
        medium[i] = medium[i] / Convert.ToDouble(size);
    }
    return medium;
}



void PrintArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{Math.Round(arr[i], 2)}\t");
    }
}





Console.Write("Введите количество строк: ");
int lines = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение генерируемого числа: ");
int randMin = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение генерируемого числа: ");
int randMax = int.Parse(Console.ReadLine()!);





int[,] myArr = GenDoubArr(lines, columns, randMin, randMax);
PrintDoubArr(myArr);
double[] med = MediumDoubArr(myArr, lines, columns);
PrintArr(med);