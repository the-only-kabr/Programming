﻿/*/Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Console.Clear();
Console.WriteLine($"Задача 62: Заполните спирально массив 4 на 4.");

int n = 4;
int[,] SquareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= SquareMatrix.GetLength(0) * SquareMatrix.GetLength(1))
{
  SquareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < SquareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= SquareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > SquareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(SquareMatrix);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

