/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 
 452 -> 11

 82 -> 10

 9012 -> 12*/
/*Console.WriteLine("Insert number");
String x = (Console.ReadLine());
//Char[]Numbers = x.ToCharArray();
int[] Digits = new int[x.Length]
//int sum = 0;
    for (int i = 0; i < x.Length; i++)
        Digits[I] = Convert.ToInt32(Numbers[I]);

//Console.WriteLine($"Inner numbers sum is = {sum}");
*/
Console.WriteLine("Insert number");
int x = int.Parse(Console.ReadLine());
int sum=0;
for (int i=3; i>=0; i--)
{
    sum+=x/(int)Math.Pow(10.0,i);
    x=x%(int)Math.Pow(10.0,i);
}
Console.WriteLine($"Number's digits sum = {sum}");