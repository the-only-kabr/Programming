// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int j = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int k = int.Parse(Console.ReadLine());

int max = i;

if (j > max) max = j;
if (k > max) max = k;

Console.WriteLine($"Максимальное число = {max}");
