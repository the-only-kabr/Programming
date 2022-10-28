/*// пишет числа от n до m;*/
Console.WriteLine("enter n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());


void FindNumber (int a, int b)
{
 if (a > b) {System.Console.WriteLine("Ошибка ввода"); return;}
 else 
 if (a == b) {System.Console.WriteLine(a); return;}   
FindNumber (a, b-1);
System.Console.WriteLine(b);
}

FindNumber(n, m);
