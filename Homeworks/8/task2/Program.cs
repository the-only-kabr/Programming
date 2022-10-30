/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
 * строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
1 строка
*/
int[,] CreateArray(int m, int n)
{ int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
       for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(1, 3);
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
GetRowSum(array);
Console.WriteLine(GetRowSum(array));
void GetRowSum(int[,] array)
{ 
    int Rowsum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    { for (int j = 0; j < array.GetLength(0); j++)
             
             Rowsum += array[i, j];
            
                    
    }return;
}
void MinSumRow(int[], array)
{ for (int j = 0; j < array.GetLength(1); j++)
    { int minsum = 0;
            int temp = GetRowSum(array, j);
        int ColumnSum = GetRowSum(array);
        if (ColumnSum < temp)
        { ColumnSum = temp;
          minsum = j;
         }
    }
            
 }
