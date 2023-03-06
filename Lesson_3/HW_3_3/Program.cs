// Реализация массивом через 2 функции (1 - возведение в квадрат, 2 - печать в консоль массива)

double[] arrCube(int num)
{
    double[] arrInt = new double[num];
    for(int i = 1; i <= num; i++)
    {
        arrInt[i - 1] = Math.Pow(i, 3);
        //Console.WriteLine(arrInt[i - 1]);
    }
    return arrInt;
}



void PrintArrCube(double[] arr)
{
    Console.Write($"{arr.Length} -> ");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

double[] wen1 = arrCube(3);
double[] wen2 = arrCube(5);

PrintArrCube(wen1);
PrintArrCube(wen2);

// Реализация через строку

void strCube(int num)
{
    string res = "";
    Console.Write($"{num} -> ");
    for(int i = 1; i <= num; i++)
    {
        res = res + Math.Pow(i, 3) + " ";
    }
    Console.WriteLine(res);
}

strCube(3);
strCube(5);
