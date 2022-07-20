// Задача 60. Сформируйте массив 3x3 из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 

// 12(0,0) 22(0,1)

// 45(1,0) 53(1,1)

Console.Write("Enter the side length of the matrix: ");
int sideLength = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int m, int n)  //заполнили матрицу
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(10, 100);
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

void AddingIndex(int[,] mat)  //просто иетрацией выводим рядом индекс
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i,j]}({i},{j}) ");
        }
        Console.WriteLine();
    }
}


int[,] newMatrix = GetMatrix(sideLength,sideLength);
PrintMatrix(newMatrix);
Console.WriteLine();
AddingIndex(newMatrix);