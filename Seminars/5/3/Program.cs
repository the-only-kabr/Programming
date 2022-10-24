// See https://aka.ms/new-console-template for more information
int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random random = new Random();  
    for (int i = 0; i < array.Lenght; i++)
    {
        array[i] = random.Next(minValue, maxValue);
    }
    return array;
    }
int[] ReverseArray(int[] array)
{ 
    for (int i = 0; i < array.Lenght; i++)
    {
        array[i] = array[i] * -1;
    }
return array;
}
Console.WriteLine(ReverseArray(CreateArray (10, -10, 10)));
