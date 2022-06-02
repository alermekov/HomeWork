// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] array = new double[3, 4];
Random random = new Random();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = random.NextDouble() * 10;
        Console.Write(Math.Round(array[i, j], 1) + " ");
    }
    Console.WriteLine();
}
*/

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateMatrix(int size1, int size2, int min, int max)
{
    int[,] matrix = new int[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

int[,] FindElement(int[,] matrix)
{
    Console.WriteLine("Input index of column element: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input index of row element: ");
    int y = Convert.ToInt32(Console.ReadLine());

    if (x > matrix.GetLength(0) || y > matrix.GetLength(1))
        Console.WriteLine("There is no element!");

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == x)
                if (j == y)
                {
                    Console.WriteLine("Matrix element is: " + matrix[i, j]);
                }
        }
    }
    return matrix;
}

FindElement(CreateMatrix(6, 6, 1, 10));
*/

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
//Console.Write("Input size of column: ");
//int size1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input size of row: ");
//int size2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[4, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 100);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

int SumOfColumn(int[,] matrix)
{
    int sum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[j, 0];
        sum = sum / 4;
    }
    return sum;
}

Console.WriteLine(SumOfColumn(matrix));
*/