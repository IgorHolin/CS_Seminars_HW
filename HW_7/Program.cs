// Задача 47. Задайте двумерный массив размером m×n
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



// 1 Вариант 

Console.Write("Enter the number of rows please: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns please: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().NextDouble();
        Console.Write($"{Math.Round(matrix[i, j]*100, 1)}    ");
    }
    Console.WriteLine();
}


// 2 Вариант через метод

Console.Write("Enter the number of rows please: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns please: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, columns];

void FillAndPrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble();
            Console.Write($"{Math.Round(matr[i, j] * 100, 1)}    ");
        }
        Console.WriteLine();
    }
}
FillAndPrintMatrix(matrix);