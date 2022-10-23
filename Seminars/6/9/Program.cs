int[] array = { 2, 5, 13, 7, 6, 4 };
int size = array.Length;
int sum = 0;
double avg = 0;
int index = 0;

    while (index < size)
     { 
        sum = sum + array[index];
        index++;
     }
avg = sum / size; 

Console.WriteLine($" Среднее арифметическое равно = { avg    , 2 } ");

