/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с 
наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка. */

Console.WriteLine("enter m, n");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} ");
        }
       Console.WriteLine();
    } 
    
}
void MinRow (int [,] array)
{
    int [] SumArray = new int [array.GetLength(0)];
    int n=0;
    for (int i=0; i<array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j=0; j<array.GetLength(1); j++)
        {
            sum=sum+array[i,j];
        }
        SumArray [n] = sum; 
        n++;
    }
        n=0;
        int min = SumArray[n];
        int minPosition=n;
    for (n=0; n<array.GetLength(0); n++)
    {
        if (SumArray[n]<min)
            {
             min=SumArray[n];
             minPosition=n;
            }
    }
    Console.WriteLine("Minimum elements sum in row "+ (minPosition+1));    
}

int [,] numbers = GetArray(m,n);
PrintArray(numbers);
MinRow(numbers);