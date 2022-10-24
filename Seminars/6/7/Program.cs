int[] CreateArray(int size)
{
	int[] array = new int[size];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = i;
int[] CreateEmptyArrayForFibbonachi(int size)
{
	int[] array = new int[size];

	array[0] = 0;
	array[1] = 1;

	return array;
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

int[] GetFibonachi(int[] emptyArray)
{
	for (int i = 2; i < emptyArray.Length; i++)
	{
		emptyArray[i] = emptyArray[i - 1] + emptyArray[i - 2];
	}

	return emptyArray;
}

int[] fib = CreateEmptyArrayForFibbonachi(8);
fib = GetFibonachi(fib);
Console.WriteLine(ArrayToString(fib));
