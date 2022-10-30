/*// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
 * значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.WriteLine("Input elements ('_'required: ");
int[] posiionarray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[,] CreateArray(int m, int n)
{ int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
       for (int j = 0; j < n; j++)
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
                    Console.Write(array[i, j] + " ");
		        }
                Console.WriteLine();
        }
}
int[,] newarray = CreateArray(5, 5);
PrintArray(newarray);
FindPosition(newarray);
void FindPosition(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == posiionarray[0] - 1 && j == posiionarray[1] - 1)
            {
                Console.WriteLine($"Search element is {array[i, j]}");
                return;
            }    
    }
    Console.WriteLine("There's not search element");
    return;
 }


