//Задача 3: Напишите программу, которая выводит 
//массив из 8 элементов (в моём коде пользователь сам задаёт количество 
//элементов), заполненный нулями и единицами в случайном порядке.

int[] NumArr()
{
    Console.Write("Введите количество элементов массива: ");
    int num = int.Parse(Console.ReadLine()!);
    int[] randArr = new int[num];
    for(int i = 0; i < num; i++)
    {
        randArr[i] = new Random().Next(0,2);
    }
    return randArr; 
}

void PrintArr(int[] arr)
{
    Console.WriteLine($"Массив из {arr.Length} рандомных элементов 0 или 1: ");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

PrintArr(NumArr());


