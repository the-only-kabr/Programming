// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int j = int.Parse(Console.ReadLine());

    if (i < j)
{
    Console.WriteLine($"Наименьшее число {i} , а наибольшее = {j}"); 
    
}
    else
{
    Console.WriteLine($"Наименьшее число {j} , а наибольшее = {i}");

}
    