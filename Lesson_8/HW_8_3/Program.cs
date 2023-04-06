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

void multiMatrix(int[,] matrix_1, int[,] matrix_2, int[,] tampleMultiMatrix)
{
    if (matrix_1.GetLength(1) == matrix_2.GetLength(0))
    {
        for (int i = 0; i < tampleMultiMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < tampleMultiMatrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matrix_1.GetLength(1); k++)
                {
                    sum += matrix_1[i, k] * matrix_2[k, j];
                }
                tampleMultiMatrix[i, j] = sum;
            }
        }
    }
    else Console.WriteLine("no");


}


Console.WriteLine("Задайте параметры для двух матриц: ");

Console.Write("Количество строк первой матрицы: ");
int oneMatrixRow = int.Parse(Console.ReadLine()!);

Console.Write("Количество столбцов первой матрицы: ");
int oneMatrixColumn = int.Parse(Console.ReadLine()!);

Console.Write("Минимальное значение генерирунмых чисел для первой матрицы: ");
int oneMatrixRandMin = int.Parse(Console.ReadLine()!);

Console.Write("Максимальное значение генерирунмых чисел для первой матрицы: ");
int oneMatrixRandMax = int.Parse(Console.ReadLine()!);

Console.Write("Количество строк второй матрицы: ");
int twoMatrixRow = int.Parse(Console.ReadLine()!);

Console.Write("Количество столбцов второй матрицы: ");
int twoMatrixColumn = int.Parse(Console.ReadLine()!);

Console.Write("Минимальное значение генерирунмых чисел для второй матрицы: ");
int twoMatrixRandMin = int.Parse(Console.ReadLine()!);

Console.Write("Максимальное значение генерирунмых чисел для второй матрицы: ");
int twoMatrixRandMax = int.Parse(Console.ReadLine()!);

int[,] oneMatrix = GenDoubArr(oneMatrixRow, oneMatrixColumn, oneMatrixRandMin, oneMatrixRandMax);
int[,] twoMatrix = GenDoubArr(twoMatrixRow, twoMatrixColumn, twoMatrixRandMin, twoMatrixRandMax);
int[,] resMatrix = new int[oneMatrixRow, twoMatrixColumn];

PrintDoubArr(oneMatrix);
Console.WriteLine();
PrintDoubArr(twoMatrix);
Console.WriteLine();
multiMatrix(oneMatrix, twoMatrix, resMatrix);
Console.WriteLine();
PrintDoubArr(resMatrix);

