/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
using System.Xml.Schema;

int[,] CreateArray(int m, int n)
{ int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
       for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(1, 5);
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
                    Console.Write(array[i, j] + " ");
		        }
                Console.WriteLine();
        }
}
int[,] array = CreateArray(4, 4);
PrintArray(array);
Console.WriteLine();
SortRows(array);
Console.WriteLine("Array rows sorted by descending");
PrintArray(array);
void SortRows(int[,] array)
{    for (int i = 0; i < array.GetLength(0); i++)
       { for (int j = 0; j < array.GetLength(1); j++)
            { for (int k = 0; k < array.GetLength(1) - 1; k++)
                if (array[i,k] < array[i,k + 1])
                    { int temp  = array[i, k + 1];
                        array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                    }
            }
       }
}