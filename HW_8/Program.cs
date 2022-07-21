// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
 
//      1 2 3 4
//      12 13 14 5
//      11 16 15 6
//      10 9 8 7

// Идём спиралью и постепенно заполняем. Т.к мы идём от краёв к центру будем увеличивать левый и верхний индексы
// и уменьшать правый и нижний

Console.Write("Enter the length of matrix side: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[size, size]; 

int counter = 1;

int upperIndex = 0;
int rightIndex = size - 1;
int lowerIndex = size - 1;
int leftIndex = 0;

while (lowerIndex >= upperIndex || leftIndex <= rightIndex) //<-------условие выхода из цикла - пока индексы не столкнутся грубо говоря
{
    for (int i = upperIndex; i <= rightIndex; i++) //<---------------заполнили верхний ряд
    {
        matrix[upperIndex, i] = counter++;
    }
    upperIndex++; //<--- см. строку 10 и 11

    for (int j = upperIndex; j <= lowerIndex; j++) //<---------------заполнили правый столбец, начинаем со 2ой строки 
    {
        matrix[j, rightIndex] = counter++;
    }
    rightIndex--; //<--- см. строку 10 и 11

    for (int k = rightIndex; k >= leftIndex; k--) //<-----------заполнили нижний ряд, начиная с "последняя строка" - 1  
    {
        matrix[lowerIndex, k] = counter++;
    }
    lowerIndex--; //<--- см. строку 10 и 11

    for (int n = lowerIndex; n >= upperIndex; n--) //<------------заполнили левый стобец, начиная с "последний ряд" - 1
    {
        matrix[n, leftIndex] = counter++; //<--- см. строку 10 и 11
    }
    leftIndex++;
}

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
    Console.WriteLine();
}

