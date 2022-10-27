Console.WriteLine("Enter your number: ");
int n = int.Parse(Console.ReadLine());
int [] array = Fb (n);
PrintArray (array);

void PrintArray(int[] array)
{
int count = array.Length;

for (int i = 0; i < count; i++)
{
    Console.Write($"{array[i]} ");
}
    Console.WriteLine();
}


int [] Fb (int n) 
{
    int [] array = new int [n];
    array [0] = 0;
    array [1] = 1;
    for (int i = 2; i < array.Length ; i++)
    {
        array [i] = array [i-1] + array [i-2];


    }
return array;

}
