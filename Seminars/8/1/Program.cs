/*/ See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/

Console.WriteLine("Введите количество значений: ");
int m = int.Parse(Console.ReadLine());
int[] array = GetArray(m);
int[,] countarray = CountNumbers(array);
PrintArray(countarray);
int[] GetArray(int m)

{
    int[] array = new int[m];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
            array[i] = rnd.Next(1, 10);
     
    }
    return array;
}

int[,] CountNumbers(int[] array)
{
int count = 0;
int[,] countarray = new int[array.Length, 2];
    for (int i = 0; i < array.Length; i++)
    {
        countarray[i, 0] = array[i];
    }
    for (int j = 0; j < array.Length; j++)
    { 
    if (countarray[j, 0] == array[j])
        { count++;
            countarray[j, 1] = count;
        }
    }
    return countarray;
}

void PrintArray(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array2[i, j]} ");
        }
        Console.WriteLine();
    }

}