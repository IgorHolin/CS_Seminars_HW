// Треугольник Паскаля

// Честно говоря не придумал выхода так чтоб заполнять только треугольник
// В теории если мы заполняем слева направо и сверху вниз, то каждый раз
// нужно уменьшать счётчик левой границы, будет сначала 3 числа потом 2 потом 1 итд.
// существуют подозрения что нужно в 4 цикла как 62-ую задачу делать, идти от краёв к центру
// но времени на реализацию задачи уже не было, тк я уезжаю на сутки

Console.Write("Enter the length of the side please: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] pascal = new int[n, n];


int upper = 0;
int left = 0;
int right = n - 1;
for (int i = 0; i < n; i++)
{
    pascal[upper, i] = 1;
}
for (int j = 0; j < n; j++)
{
    pascal[j, left] = 1;
}


//Алгоритм заполнения
for (int k = 1; k < n; k++)
{
    for (int l = 1; l < т; l++)
    {
        pascal[k, l] = pascal[k, l - 1] + pascal[k - 1, l];
    }
}


// Вывод
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(pascal[i, j] + " ");
    }
    Console.WriteLine();
}