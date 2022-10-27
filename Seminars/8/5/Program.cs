/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] array = new int[10];

int[] CreateArray(int[] array)
{
	

	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(1, 20);
	}
	return array;
}

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
			{
			Console.Write(array[i] + " ");
		}
		Console.WriteLine();
}
CreateArray(array);
PrintArray(array);
Console.WriteLine($"Sum of odd elements = {GetSum(array)} ");
int GetSum(int[] array)
{
	int sum = array[0];
	for (int i = 0; i < array.Length; i++)
		if (i % 2 != 0)
		{ 
			sum = sum + array[i] ;
			
		}
	return sum;
	}

