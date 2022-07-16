// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет
// Решал по нахождению числа под введённым индексом и функциями (давно не делал)

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

void InOrNot(int[,] mat, int row, int column)

{
    if (row < mat.GetLength(0) && column < mat.GetLength(1))
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if (i == row && j == column) Console.WriteLine($"The digit under this index is: {mat[i, j]}");
            }
        }
    }
    else Console.WriteLine("Number doesnt exist");
}

    FillAndPrintMatrix(matrix);
    Console.Write("Enter the first index: ");
    int firstIndex = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the second index: ");
    int secondIndex = Convert.ToInt32(Console.ReadLine());
    InOrNot(matrix, firstIndex, secondIndex);