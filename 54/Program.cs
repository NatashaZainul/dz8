// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

int[, ] SortMatrix (int[, ] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
           for (int m = 0; m < matrix.GetLength(1) - 1; m++)
            {
               if (matrix[i, m] < matrix[i, m + 1])
               {
                   int temp = 0;
                    temp = matrix[i, m];
                    matrix[i, m] = matrix[i, m + 1];
                    matrix[i, m + 1] = temp;
               }
            }
        }
    }
    return matrix;
}


void PrintMatrix(int[, ] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
          Console.Write($"{matrix[i, j]} \t");
      }
      Console.WriteLine();
  }
}

Console.WriteLine("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[size[0], size[1]];

InputMatrix(matrix);
SortMatrix (matrix);
Console.WriteLine();
PrintMatrix(matrix);


