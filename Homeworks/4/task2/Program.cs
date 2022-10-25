/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 
 452 -> 11

 82 -> 10

 9012 -> 12*/

int number = int.Parse(Console.ReadLine());

int Digits(int number)

{

    int result = 0;

    while (number > 0)

    {

        result = result + number % 10;

        number = number / 10;



    }

    return result;

}



void GetSum(int number)

{

    int newnum = number;

    int result = Digits(number);

}



Console.WriteLine(Digits(number));




/*Console.WriteLine("Insert number");
String x = (Console.ReadLine());
//Char[]Numbers = x.ToCharArray();
int[] Digits = new int[x.Length]
//int sum = 0;
    for (int i = 0; i < x.Length; i++)
        Digits[I] = Convert.ToInt32(Numbers[I]);

//Console.WriteLine($"Inner numbers sum is = {sum}");

Console.WriteLine("Insert number");
string x = int.Parse(Console.ReadLine());
int sum=0;
for (int i=x.Length; i>=0; i--)
{
    sum+=x[i]/(int)Math.Pow(10.0,i);
    x[i]=x[i]%(int)Math.Pow(10.0,i);
}
Console.WriteLine($"Number's digits sum = {sum}");*/