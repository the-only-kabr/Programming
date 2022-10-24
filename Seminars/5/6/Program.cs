// See https://aka.ms/new-console-template найти от 10 до 99
int[] CreateArray(int size, int min, int max)
{
	int[] array = new int[size];
	Random rnd = new Random();

	for (int i = 0; i < size; i++)
	{
		array[i] = rnd.Next(min, max);
	}

	return array;
}
int FindCount(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
		if (array[i] >= 10 && array[i] <= 99)
			count++;
	return count;
}


int[] array = CreateArray(123, 0, 150);


Console.WriteLine(FindCount(array));