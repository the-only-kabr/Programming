/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

//using System.Security.Cryptography;

int n = int.Parse(Console.ReadLine());

void LineNumbers(int n)
{
    if (n == 0) { System.Console.WriteLine(n); return; }
    LineNumbers(n);
    System.Console.WriteLine(n);
}

LineNumbers(n);
