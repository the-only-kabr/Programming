/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] array = new int[10];

int[] CreateArray(int[] array)
{
	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(100, 999);
	}
	return array;
}

void PrintArray(int[] array)
{

    for (int i = 0; i < n; i++)
    {
    Console.Write(array[i] + " ");
        Console.WriteLine();
    }
}

void FindEvens(int[], array)
int result = 0;
{
    for (int i = 0; i < n; i++)
    {
        if (array[i] % 2 = 0)
        {
            result +=        
        }
    }
    return result;
}

int[] array = CreateArray();
PrintArray(array);
Console.WriteLine();

	for (int i = 0; i < array.Length; i++)
			{
			Console.Write(array[i] + " ");
		}
		Console.WriteLine();
}
CreateArray(array);
PrintArray(array);
GetEvenCount(array);

Console.WriteLine($"Count of even numbers is = {GetEvenCount(array)} ");
int GetEvenCount(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
		if ((array[i] % 2) == 0)
		{ 
			count++;
		}
		return count;
}

