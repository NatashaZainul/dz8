// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillMatrixRandomNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10); 
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = InputInt("Введите длину матрицы: ");
int[,] matrix1 = new int[size, size];
int[,] matrix2 = new int[size, size];
FillMatrixRandomNumbers(matrix1);
FillMatrixRandomNumbers(matrix2);
int[,] matrix3 = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int m = 0; m < size; m++)
        {
            matrix3[i, j] = matrix3[i, j] + (matrix1[i, m] * matrix2[m, j]);
        }
    }
}

Console.WriteLine("Матрица - 1");
PrintMatrix(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица - 2");
PrintMatrix(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц 1*2");
PrintMatrix(matrix3);