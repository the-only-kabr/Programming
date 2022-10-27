int[,] UpdateArray(int[,] array)
{
	int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];

	if (array.GetLength(1) != array.GetLength(0))
	{
		throw new ArgumentException("Thiw array can't be reversed");
	}

	for (int i = 0; i < array.GetLength(1); i++)
	{
		int[] column = CopyColumn(array, i);

		AddRowToArray(array, newArray, column, i);
	}



	return newArray;
}

int[] CopyColumn(int[,] array, int columnNumber)
{
	int[] coulumn = new int[array.GetLength(0)];

	for (int i = 0; i < coulumn.Length; i++)
	{
		coulumn[i] = array[columnNumber, i];
	}

	return coulumn;
}

void AddRowToArray(int[,] originArray, int[,] copiedArray, int[] row, int rowNumber)
{
	for (int i = 0; i < originArray.GetLength(0); i++)
	{
		copiedArray[i, rowNumber] = row[i];
	}
}

int[,] CreateArray(int m, int n)
{
	int[,] array = new int[m, n];

	Random random = new Random();

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = random.Next(1, 20);
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

int[,] array = CreateArray(5, 5);
PrintArray(array);

Console.WriteLine();

int[,] newArray = UpdateArray(array);
PrintArray(newArray);
