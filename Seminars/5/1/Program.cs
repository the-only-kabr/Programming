// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Введите число");
//using System.Runtime.CompilerServices;

int[] createarray()
    {
int ints = new int[a];
Random random = new Random();
for (int i= 0; i < ints.lenght; i++) {Ints[i] = Random.next(); 
return ints;
}
string GetArrayAsString(int[] array) 
{
string Result = "";
    for (int i = 0; i < array.Length; i++) 
    {
        Result += $"{array[i]}.ToString()
            }
    return Result;
}
Console.WriteLine(GetArrayAsString(createarray()));