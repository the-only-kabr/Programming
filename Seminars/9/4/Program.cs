/*/ сумма цифр; и возведение в степень числа Б числа А рекурсия
*/
/*Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());

int digitsSum(int N)
{
    if (N / 10 == 0) return N;
    return N % 10 + digitsSum(N / 10);
}

System.Console.WriteLine(digitsSum(m));
*/
Console.WriteLine("enter A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("enter B: ");
int B = int.Parse(Console.ReadLine());

int degreeNatural (int a, int b)
{
    if (b == 0) return a;
    return degreeNatural (a, b-1) * a;
}

System.Console.WriteLine(degreeNatural(A, B));
 
