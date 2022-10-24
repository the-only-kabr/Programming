<<<<<<< HEAD
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите пятизначное число");
int array[] = int.Parse(Console.ReadLine());

int n = Array.Lenght();
int i = 0;
if (array[i]==array[n-i])
{
    Console.WriteLine("It's a palindrom"");
}
else

Console.WriteLine("It isn't a palindrom");

﻿/*Палиндром для любых чисел
 непонятно почему не работает отсев по количеству символов - разобрать*/

Console.WriteLine("Введите число");

string x = Console.ReadLine();

int i =0, j = x.Length-1;

//if (x.Length > 5 && x.Length < 5)
//    Console.WriteLine("Введено не пятизначное число");

while ((i<j) && (x[i] == x[j]))

{i++; j--;}

if (x[i] == x[j])

Console.WriteLine("Это палиндром!");

else

Console.WriteLine("Это не палиндром!");
>>>>>>> 258de455cb8ab6045df6d555061e9cae0d3baf3f
