// See https://aka.ms/new-console-template for more information
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

int[] GetReverseArray(int[] array)
{
	int[] reversedArray = new int[array.Length];

	for (int i = 0; i < array.Length; i++)
	{
		reversedArray[i] = -array[i];
	}

	return reversedArray;
}

string ArrayToString(int[] array)
{
	string result = "[";

	foreach (int item in array)
	{
		result += $"{item}, ";
	}

	result += "]";

	return result;
}

bool FindNumber(int[] array, int number)
{
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] == number)
			return true;
	}

	return false;
}

int[] array = CreateArray(20, -5, 5);

int findNumber = int.Parse(Console.ReadLine());


Console.WriteLine(ArrayToString(array));
Console.WriteLine(ArrayToString(GetReverseArray(array)));
Console.WriteLine(FindNumber(array, findNumber));
