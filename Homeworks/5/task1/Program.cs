/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] array = new int[20];
Random rnd = new Random();
	/*for (int i = 0; i < array.Length; i++)
		{
		array[i] = rnd.Next(100, 999);
		Console.WriteLine(array[i]);
		}*/
string ArrayToString(int[] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = rnd.Next(100, 999);
		result += $"{array[i]}, ";
		
	}

	return result;
}
Console.WriteLine(ArrayToString(array));

int FindCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        {
        if (array[i] % 2 = 0);
            count++;
        }
    return count;
}

Console.WriteLine(FindCount(array));
