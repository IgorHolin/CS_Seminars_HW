// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Write("Enter the size of array please: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
double[] array = new double[arraySize];

for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().NextDouble(); //чтоб не морочаться сделал просто рандомДабл заполняшку
}
Console.WriteLine($"Array: [{String.Join("; ", array)}]");
double maxDigit = array.Max();
Console.WriteLine($"Maximal digit in array is: {maxDigit}");
double minDigit = array.Min();
Console.WriteLine($"Minimal digit in array: {minDigit}");
Console.Write($"The difference between maximal and minimal digits is: {maxDigit - minDigit}");

