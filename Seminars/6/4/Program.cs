
/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 
0 и 1. 
Если N = 5 -> 0 1 1 2 3 
Если N = 3 -> 0 1 1 
Если N = 7 -> 0 1 1 2 3 5 8*/

System.Console.WriteLine("введине число для расчета");
int n = int.Parse(Console.ReadLine());
int Result =0;
int ferst = 0;
System.Console.WriteLine($"{ferst}");
int second = 1; 
System.Console.WriteLine($"{second}");
for(int i =0; i<n; i++)
{
    Result = ferst + second;
    ferst = second;
    second = Result;
    System.Console.WriteLine($"{Result}");
        
}
