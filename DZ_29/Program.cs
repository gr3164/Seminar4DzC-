// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] arr = new int[8];

void FillArray(int[] Array)
{
    int length = Array.Length;
    int index = 0;
    while(index < length)
    {
        Array[index] = new Random().Next(0, 100);
        Console.Write(arr[index] + ", ");
        index++;
    }
}


FillArray(arr);
Console.WriteLine();
