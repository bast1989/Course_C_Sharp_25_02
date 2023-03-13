int[] Fib(int size)
{
    int a = 0;
    int b = 1;
    //int temp = 0;
    int[] arr = new int[size];
    arr[0] = a;
    arr[1] = b;

    for(int i = 2; i < size; i++)
    {
        /*
        temp = a + b;
        arr[i] = temp;
        a = b;
        b = temp;
        */

        arr[i] = a + b;
        a = b;
        b = arr[i];
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

PrintArr(Fib(5));
Console.WriteLine();
PrintArr(Fib(3));
Console.WriteLine();
PrintArr(Fib(7));
Console.WriteLine();
PrintArr(Fib(10));

void Fi(int size)
{
    int a = 0;
    int b = 1;
    
    for(int i = 0; i < size; i++)
    {
        Console.Write((a) + " ");
        (a, b) = (b, a + b);
    }

}

Console.WriteLine("\n");
Fi(5);
Console.WriteLine();
Fi(3);
Console.WriteLine();
Fi(7);
Console.WriteLine();
Fi(10);
    
