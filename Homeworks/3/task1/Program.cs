/*Палиндром для любых чисел
 непонятно почему не работает отсев по количеству символов - разобрать*/

Console.WriteLine("Введите число");

string x = Console.ReadLine();

int i =0, j = x.Length-1;

//if (x.Length > 5 && x.Length < 5)
//    Console.WriteLine("Введено не пятизначное число");

while ((i<j) && (x[i] == x[j]))

{i++; j--;}

if (x[i] == x[j])

Console.WriteLine("Это палиндром!");

else

Console.WriteLine("Это не палиндром!");
