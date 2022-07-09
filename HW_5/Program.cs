// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Enter the size of array please: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] newArray = new int[arraySize];
int unevenSum = 0;

for (int i = 0; i < arraySize; i++)
{
    newArray[i] = new Random().Next(-10, 11);
    if (i % 2 != 0) 
    {
        Console.WriteLine($"Element {newArray[i]} has uneven index {i}"); // можно без райтлайна и короче, но с выводом в консоли
        unevenSum += newArray[i];                                         // получается удобно искать и считать :)
    }
}
Console.WriteLine($"Your array is: [{String.Join(",", newArray)}]");
Console.WriteLine($"The sum of elements with uneven index is: {unevenSum}");
