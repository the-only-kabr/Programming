// See https://aka.ms/new-console-template for more information
int[] CreateArray(int size, int minValue, int maxValue);
{
    int[] array = new int[size];
    Random random = new Random();  
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue);
    }
    return array;
}

int GetSumPositiveElementsFromArray(int[] array)
{  int sum = 0;
for ( int i = 0; i < array.Length; i++)
    { 
    if (array[i] > 0) sum = sum + array[i];
    }
return sum;
}

int[] array = CreateArray(12, -9, 10);

Console.WriteLine("Сумма положительных элементов = " + GetSumPositiveElementsFromArray(int[] array));
Console.WriteLine("Сумма отрицательных элементов = " + GetSumNegativeElementsFromArray(int[] array));

int GetSumNegativeElementsFromArray(int[] array)
{  string sum = String.Empty;
for ( int i = 0; i < array.Length; i++)
    { 
    sum = sum + $"{array[i]}, ";
    }
return sum;
}
Console.WriteLine((Getarray{ array});
Console.WriteLine("Сумма положительных элементов = " + GetSumPositiveElementsFromArray(int[] array));
Console.WriteLine("Сумма отрицательных элементов = " + GetSumNegativeElementsFromArray(int[] array));


