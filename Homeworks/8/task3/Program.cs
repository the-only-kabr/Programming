/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18   */
Console.WriteLine("enter m1, n1");
int m1 = int.Parse(Console.ReadLine());
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter m2, n2");
int m2 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine();

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

int [,] ProdArray (int[,] array1, int[,] array2)

{
    if  ((array1.GetLength(1)==array2.GetLength(0))==true) 
    {
        int [,] newArray = new int [array1.GetLength(0),array2.GetLength(1)];
        
        for (int i=0; i<array1.GetLength(0); i++)  
        {  
            for (int j=0; j<array2.GetLength(1); j++)
            {
                for (int k=0; k<array2.GetLength(0); k++)
                {
                    newArray[i,j]+=array1[i,k]*array2[k,j];

                }
            }
        }
        return newArray;
    }
    else Console.WriteLine("Matrixes production isn't possible");
    return array1;
}

int [,] array1= GetArray(m1,n1);
int [,] array2= GetArray(m2,n2);
PrintArray(array1);
Console.WriteLine();  
PrintArray(array2);
Console.WriteLine();  
PrintArray(ProdArray(array1,array2));