
int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine(ArrayToString(array));

int[] newArray = TransporateArray(array);
Console.WriteLine(ArrayToString(newArray));

Transporate(array);
Console.WriteLine(ArrayToString(array));

string ArrayToString(int[] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.Length; i++)
	{
		result += $"{array[i]}, ";
	}

	return result;
}

int[] TransporateArray(int[] originArray)
{
	int[] newArray = new int[originArray.Length];

	for (int i = 0; i < originArray.Length; i++)
	{
		newArray[i] = originArray[originArray.Length - 1 - i];
	}

	return newArray;
}

void Transporate(int[] originArray)
{
	for (int i = 0; i < originArray.Length / 2; i++)
	{
		int buffer = originArray[i];
		originArray[i] = originArray[originArray.Length - 1 - i];
		originArray[originArray.Length - 1 - i] = buffer;
	}
}
