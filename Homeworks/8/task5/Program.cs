/* Задача 62. Напишите программу, которая заполнит
 спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Console.WriteLine("enter m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();


int[,] GetSquareArray(int m)
{
    int[,] array = new int[m, m];
   int c=1; int i=0; int j=0;
   int count;
    while (m>1)  
   {
        for (count =0; count<m-1;count ++)
                 { array [i,j]=c; c++;j++; } 
        for (count = 0; count<m-1;count ++)
                 {array[ i, j] = c; c++; i++;} 
        for (count =0; count<m-1; count ++)
                 {array[ i, j] = c; c++; j--; } 
        for (count =0; count<m-1; count ++)
                 {array[ i, j] = c; c++; i--;} 
       i++; j++;
       m-=2;
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

PrintArray(GetSquareArray(m));


