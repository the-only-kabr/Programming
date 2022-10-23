/*Console.WriteLine("Insert 5 digits");
int[] palindrom = int.Parse(Console.ReadLine(palindrom));
Console.WriteLine(ArrayToString(palindrom));
string ArrayToString(int[] palindrom);


for (int i = 0; i < palindrom.Length; i++);
   if (palindrom[i] == palindrom[palindrom.Length -1 - i])
 
    Console.WriteLine("It is palindrom");
   else
    Console.WriteLine("It is not a palindrom");*/


Console.WriteLine("Insert 5 digits");
string x = Console.ReadLine();
int i = 0;
if (x.Length != 5)
    Console.WriteLine("It isn't 5 digits number");

else if (x[i] == x[x.Length -1 - i])
    {  i++;  
     Console.WriteLine("It is palindrom");
    }
   
   else
    Console.WriteLine("It is not a palindrom");