// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 5);
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void MinSumMatrix (int[, ] matrix)

{
    int minsum = Int32.MaxValue;
    int indexLine = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    { 
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];        
        }
            if (sum < minsum)
            {
                minsum = sum;
                indexLine++;
            }    
    }
Console.WriteLine($"Строка с наименьшей суммой элементов: {indexLine}, сумма: {minsum}"); 
}
    
  

Console.WriteLine("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[size[0], size[1]];

InputMatrix(matrix);
Console.WriteLine();
MinSumMatrix (matrix);





