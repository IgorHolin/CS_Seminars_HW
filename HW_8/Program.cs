// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int n = 4;
int[,] matrix = new int[n, n];

int counter = 1;
int begrow = 0;
int endcol = n-1;
int endrow = n-1;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    matrix[begrow,i] = counter;
    counter++;
}
begrow++;

for (int i = begrow; i < matrix.GetLength(1); i++)
{
    matrix[endcol,i] = counter;
    counter++;
}
endcol--;

for (int i = endcol; i > 0 ; i--)
{
    matrix[endrow,endcol] = counter;
    counter++;
}
endrow--;

for ()