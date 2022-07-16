// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Set the width of matrix: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Set the heigth of matrix: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];

void FillAndPrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 9);
            Console.Write($"{matr[i, j]}    ");
        }
        Console.WriteLine();
    }
}

void FindAverage(int[,] mat)
{
    double[] outArr = new double[mat.GetLength(1)];
    double sum = 0;
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            sum = sum + mat[j, i];
            
        }
        outArr[i] = Math.Round(sum / mat.GetLength(0), 2);
        sum = 0;
    }
    Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join(";  ", outArr)}");
}

FillAndPrintMatrix(matrix);
FindAverage(matrix);