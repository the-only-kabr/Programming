/* See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/
Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());

void FindNumber (int a)
{
 if (a == 1) {System.Console.WriteLine(a); return;}   
FindNumber (a-1);
System.Console.WriteLine(a);
}

FindNumber(m);
