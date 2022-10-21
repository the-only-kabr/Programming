// See https://aka.ms/new-console-template for more information
    Console.WriteLine("Введите число");
    int x = int.Parse(Console.ReadLine());

    for (int i = 0; x > 999; i++)
{
    x = x / 10;
}
    if (x < 1000 && x > 99)
{
    Console.WriteLine(x % 10);
}
    else
{
    Console.WriteLine("There's no 3rd number");
}
