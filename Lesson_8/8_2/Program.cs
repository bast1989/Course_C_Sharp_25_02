//Моё решение
/*
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
    int maxNum = arr.Cast<int>().Max();
    int[] containsArr = new int[maxNum + 1];
    
    foreach (int i in arr)
    {
        containsArr[i] += 1;
    }
    return containsArr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i == 0) Console.WriteLine($" {i} встречается {arr[i]} ");
        if(i > 0 && arr[i] != 0) Console.WriteLine($" {i} встречается {arr[i]} ");
    }
}


int[,] myArr = GenDoubArr(5, 5, 0, 9);
PrintDoubArr(myArr);
Console.WriteLine("\n");
int[] numArr = CountArr(myArr);
PrintArr(numArr);
*/

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

int[] FrequencyDict(int[,] arr, int max_num)
{
    int[] freq = new int[max_num];

    foreach (int item in arr) freq[item] += 1;
    return freq;
}

void PrintMass(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine($"{i} meets: {arr[i]}");
    Console.WriteLine();
}


Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[,] mass = MassNums(row_num, column_num, start, stop);

Print(mass);

int[] new_mass = FrequencyDict(mass, stop);
PrintMass(new_mass);