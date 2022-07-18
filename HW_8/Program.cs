// Задача 54: Задайте двумерный массив. Напишите программу
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

// Сначала принимаем число рядов и строк матрицы заполняем её рандомом а потом выводим
// Потом сортируем числа и выводим новый массив

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

void SortMatrix(int[,] matr)
{
    int maxDigit = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            if (matr[i, j] < matr[i, j + 1])
            {
                int temp = matr[i, j];
                matr[i, j] = matr[i, j + 1];
                matr[i, j + 1] = temp;
            }
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] newMatrix = GetMatrix(rows, columns);
PrintMatrix(newMatrix);
Console.WriteLine();
SortMatrix(newMatrix);
// PrintMatrix(resultMatrix);
