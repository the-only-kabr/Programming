// See https://aka.ms/new-console-template for more information
Console.WriteLine("Insert number");
int x = int.Parse(Console.ReadLine());

    if (x > 99 && x < 1000)
        Console.WriteLine((x % 100 - x % 10)/10);
    else
    Console.WriteLine("Wrong insertion");
    
    
