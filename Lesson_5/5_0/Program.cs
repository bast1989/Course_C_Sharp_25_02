/*
// 2 цикла
void SumArr()
{
    int[] numArr = new int[12];
    int numPos = 0;
    int numNeg = 0;
    int zero = 0;
    for(int i = 0; i < numArr.Length; i++)
    {
        numArr[i] = new Random().Next(-9, 10);
        Console.Write(numArr[i] + " ");
    }
    Console.WriteLine();
    for(int i = 0; i < numArr.Length; i++)
    {
        if(numArr[i] > 0) numPos += numArr[i];
        else if(numArr[i] < 0) numNeg += numArr[i];
        else zero++;
    }

    Console.WriteLine($"Массив содержит чисел - положительных: {numPos}, отрицательных: {numNeg}, нулей: {zero}");

}

// 1 цикла
void SumArr2()
{
    int[] numArr = new int[12];
    int numPos = 0;
    int numNeg = 0;
    int zero = 0;
    for(int i = 0; i < numArr.Length; i++)
    {
        numArr[i] = new Random().Next(-9, 10);
        Console.Write(numArr[i] + " ");
        if(numArr[i] > 0) numPos += numArr[i];
        else if(numArr[i] < 0) numNeg += numArr[i];
        else zero++;
    }
    Console.WriteLine();
    Console.WriteLine($"Массив содержит чисел - положительных: {numPos}, отрицательных: {numNeg}, нулей: {zero}");
}
*/


// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

int[] GenArr(int size, int randMin, int randMax)
{
    int[] numArr = new int[size];
    for(int i = 0; i < numArr.Length; i++)
    {
        numArr[i] = new Random().Next(randMin, randMax + 1);
        
    }
    return numArr;
}

void PrintArr(int[] intArr)
{
    for(int i = 0; i < intArr.Length; i++)
    {
        Console.WriteLine(intArr[i]);
    }
}

void SumArr(int[] intArr)
{
    int numPos = 0;
    int numNeg = 0;
    int zero = 0;

    for (int i = 0; i < intArr.Length; i++)
    {
        if(intArr[i] > 0) numPos += intArr[i];
        else if(intArr[i] < 0) numNeg += intArr[i];
        else zero++;
    }

    Console.WriteLine($"Массив содержит чисел - положительных: {numPos}, отрицательных: {numNeg}, нулей: {zero}");
}


int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] myArr = GenArr(num, start, stop);
Console.WriteLine();
PrintArr(myArr);
Console.WriteLine();
SumArr(myArr);




