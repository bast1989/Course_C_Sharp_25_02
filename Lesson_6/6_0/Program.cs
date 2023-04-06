int[] GenArr(int size, int start, int stop)
{
    int[] intArr = new int[size];
    for(int i = 0; i < intArr.Length; i++)
    {
        intArr[i] = new Random().Next(start, stop + 1);
    }
    return intArr;
}

void PrintArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

/*
int[] RevArr(int[] arr)
{
    int[] rArr = new int[arr.Length];
    int count = 0;
    for(int i = arr.Length - 1; i >= 0; i--)
    {
        rArr[count] = arr[i];
        count++;
    }
    return rArr;
}


int[] RevArr(int[] arr)
{
    int size = arr.Length;
    int[] rArr = new int[arr.Length];   
    for(int i = 0; i < size; i++)
    {
        rArr[size - i - 1] = arr[i];
    }
    return rArr;
}

*/

int[] RevArr(int[] arr)
{
    int size = arr.Length;    
    for(int i = 0; i < size / 2; i++)
    {
        (arr[i], arr[size - i - 1]) = (arr[size - i - 1], arr[i]);
    }
    return arr;
}



int[] myArr = GenArr(5, 12, 30);
PrintArr(myArr);
Console.Write("-> ");
int[] myReArr = RevArr(myArr);
PrintArr(myReArr);
