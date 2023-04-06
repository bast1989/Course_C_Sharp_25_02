// 1. Напишите программу замена элементов массива:
//    положительные элементы замените на соответствующие отрицательные, и наоборот.

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
        Console.Write(intArr[i] + " ");
    }
}

int[] RevArr(int[] intArr)
{
    for (int i = 0; i < intArr.Length; i++)
    {
        intArr[i] = - intArr[i];        
    }
    return intArr;    
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] myArr = GenArr(num, start, stop);
PrintArr(myArr);
Console.Write("-> ");
int[] revMyArr = RevArr(myArr);
PrintArr(revMyArr);


