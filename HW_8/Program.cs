// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Получаем массив, проходимся итерацией по строкам, записываем сумму элементов в счётчик, сравниваем и меньший оставляем -> вывод.

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

void MinorSumString(int[,] mat) // сравнили + вывод
{
    int index = 0;
    int minSum = int.MaxValue;
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            temp += mat[i, j];
        }
        if (temp < minSum)
        {
            minSum = temp;
            index = i;
        }
    }
    Console.WriteLine();
    for (int k = 0; k < mat.GetLength(1); k++)
    {
        Console.Write(mat[index, k] + "\t");
    }
}


int[,] newMatrix = GetMatrix(rows, columns);
PrintMatrix(newMatrix);
MinorSumString(newMatrix);