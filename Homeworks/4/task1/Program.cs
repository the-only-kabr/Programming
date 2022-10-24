/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 
 3, 5 -> 243 (3⁵)

 2, 4 -> 16*/

Console.WriteLine("Insert number");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Insert count");
int y = int.Parse(Console.ReadLine());

double res = 0;
res = Math.Pow(x, y);

Console.WriteLine($"Result is = {res}");

