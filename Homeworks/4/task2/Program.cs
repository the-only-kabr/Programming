/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 
 452 -> 11

 82 -> 10

 9012 -> 12*/
Console.WriteLine("Insert number");
string x = Console.ReadLine();
int sum = 0;
    for (int i = 0; i < x.Length; i++)
        sum = sum + x[i];

Console.WriteLine($"Inner numbers sum is = {sum}");
