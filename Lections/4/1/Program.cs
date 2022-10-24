//string[,] table = new string[2, 5];
//table[1, 2] = "слово";

//for (int rows = 0; rows < 2; rows++)
//    for (int cols = 0; cols < 5; cols++)
//   {
//       Console.WriteLine($"-{table[rows, cols]}-");
//    }
//}


void PrintArray(int[,] matr);
  for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.WriteLine($"{matr[i, j]}");
    }
//  Console.WriteLine();
}
  Console.WriteLine();  
//int[,] matrix = new int[3,4];
//PrintArray(matrix);