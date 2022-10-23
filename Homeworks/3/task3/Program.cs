
Console.WriteLine("Введите число: ");
double count = int.Parse(Console.ReadLine());

double GetCube (double count)
{
    double cube = 0;
    for (int i = 1; i <= count; i++)
    {
        cube = Math.Pow(i, 3);
        Console.WriteLine(cube);
    }
    return cube;
}
Console.WriteLine(GetCube(count);