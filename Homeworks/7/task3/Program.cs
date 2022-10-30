/*/ Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
int[,] newarray = CreateArray(4, 4);
PrintArray(newarray);
GetColumnSum(newarray); 
void GetColumnSum(int[,] array)
{   
    for (int j = 0; j < array.GetLength(1); j++)
    { int columnssum = 0;
             for  (int i = 0; i < array.GetLength(0); i++)
                    { 
                     columnssum += array[i, j];
                    }
        Console.WriteLine($"Average sum of column {j + 1} = {(double)columnssum / array.GetLength(1)}");
    }return;
}
