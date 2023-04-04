// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int a = InputInt("Введите размерность 1: ");
int b = InputInt("Введите размерность 2: ");
int c = InputInt("Введите размерность 3: ");
int number = 99;

if (a * b * c > number)
{
    Console.Write("Введите размерность до 5");
    return;
}

int[,,] result = Create3DMatrix(a, b, c);

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        for (int k = 0; k < result.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {result[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] Create3DMatrix(int size1, int size2, int size3)
{
    int[,,] matrix = new int[size1, size2, size3];
    int[] values = new int[number];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomIndex = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomIndex];
        values[randomIndex] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = values[valueIndex++];
            }
        }
    }
    return matrix;
}

