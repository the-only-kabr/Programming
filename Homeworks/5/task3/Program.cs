/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
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
GetMax(array);
GetMin(array);
Console.WriteLine($"Max - min = {GetMax(array) - GetMin(array)} ");
int GetMax(int[] array)
{
	int Max = array[0];
	for (int i = 0; i < array.Length; i++)
		if (Max < array[i] )
		{ 
			Max = array[i];
		}
		return Max;
}

int GetMin(int[] array)
{
	int Min = array[0];
	for (int i = 0; i < array.Length; i++)
				if (Min > array[i])
				{
				Min = array[i];
				}
	return Min;
}
