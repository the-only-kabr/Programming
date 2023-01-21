/*/Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
 * элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("enter m, n");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
if (m>n) Console.WriteLine("Ошибка ввода");
int Numbers (int m, int n)
{   
      
        if (m==n) 
        return m;
        else
        {
       return Numbers(m,n-1)+n;
        
                 
        }
}

Console.WriteLine(Numbers(m,n));