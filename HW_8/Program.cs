// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2       1 5 8 5
// 5 9 2 3   и   4 9 4 2
// 8 4 2 4       7 2 2 6
// 5 2 6 7       2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

// Строго говоря тут в примере подано не произведение 2-ух матриц а произведение членов матриц с одинаковыми индексами, так что решал так же.

Console.Write("Enter the amount of rows in matrix: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the amount of columns in matrix: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int m, int n)  //заполнили матрицу
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrx)  //вывели матрицу
{
    for (int i = 0; i < matrx.GetLength(0); i++)
    {
        for (int j = 0; j < matrx.GetLength(1); j++)
        {
            Console.Write(matrx[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void MultipliedMatrix(int[,] firstMatr, int[,] secondMatr)
{
    int resulMatrixRow = Math.Max(firstMatr.GetLength(0),secondMatr.GetLength(0));
    int resulMatrixColumns = Math.Max(firstMatr.GetLength(1),secondMatr.GetLength(1));
    int [,] resultMatr = new int[resulMatrixRow, resulMatrixColumns];

        for (int i = 0; i < resulMatrixRow; i++)
        {
            for (int j = 0; j < resulMatrixColumns; j++)
            {
             resultMatr[i,j] = firstMatr[i,j] * secondMatr[i,j];
             Console.Write(resultMatr[i,j] + "\t"); 
            }
            Console.WriteLine();
        }

}

int[,] firstMatrix = GetMatrix(rows, columns);
int[,] secondMatrix = GetMatrix(rows, columns);
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
MultipliedMatrix(firstMatrix,secondMatrix);