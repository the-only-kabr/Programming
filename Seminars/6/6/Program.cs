int[] CreateArray(int size)
{
	int[] array = new int[size];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = i;
	}

	return array;
}

int[] CopyArray(int[] originArray)
{
	int[] newArray = new int[originArray.Length];

	for (int i = 0; i < newArray.Length; i++)
	{
		newArray[i] = originArray[i];
	}

	return newArray;
}

string ArrayToString(int[] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.Length; i++)
	{
		result += array[i] + " ";
	}

	return result;
}
int[] array = CreateArray(10);
Console.WriteLine(ArrayToString(array));
Console.WriteLine(ArrayToString(CopyArray(array)));
