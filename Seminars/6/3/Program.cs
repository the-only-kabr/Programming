string DecNumber(int number)
{
	string result = string.Empty;

	while (number > 0)
	{
		result += number % 2;
		number /= 2;
		Console.WriteLine(number);
	}

	return result;
}

Console.WriteLine(DecNumber(45));


/*int value= int.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            Console.WriteLine(binary);
*/