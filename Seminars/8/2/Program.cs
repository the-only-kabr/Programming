/* убирает строку и столбец по минимальному элементу*/

int[,] RemoveMinColumnsAndRowsFromArray(int[,] array)
{
	int min = 0;
	int min_x = 0;
	int min_y = 0;

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if (array[i, j] < min)
			{
				min = array[i, j];
				min_x = i;
				min_y = j;
			}
		}
	}

	int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

	for (int i = 0; i < result.GetLength(0); i++)
	{
		for (int j = 0; j < result.GetLength(1); j++)
		{
			if (i != min_x || j != min_y)
			{
				result[i, j] = array[i, j];
			}
		}
	}

	return result;
}
int[]