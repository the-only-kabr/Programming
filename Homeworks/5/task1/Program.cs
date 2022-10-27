/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

Console.WriteLine("Insert number of array elements = ");
Console.WriteLine();
int n = int.Parse(Console.ReadLine());
int[] CreateArray()
{
    int[] array = new int[n];
    Random r = new Random();
    for (int i = 0; i < n; i++)
    {
            array[i] = r.Next(100, 999);
        }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < n; i++)
    {
    Console.Write(array[i] + " ");
        Console.WriteLine();
    }
}

void FindEvens(int[], array)
int result = 0;
{
    for (int i = 0; i < n; i++)
    {
        if (array[i] % 2 = 0)
        {
            result +=        
        }
    }
    return result;
}

int[] array = CreateArray();
PrintArray(array);
Console.WriteLine();
