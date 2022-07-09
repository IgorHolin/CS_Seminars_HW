// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Enter the size of array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int [] array = new int[arraySize];
int evenCounter = 0;
for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0) 
    {
        Console.WriteLine($"{array[i]} is even!");   // можно просто каунтэр увеличивать, но чтоб проще было смотреть какие числа
        evenCounter +=1;                             // решил сделать вывод
    }
}
Console.WriteLine($"The array looks like: [{String.Join(",", array)}]");
Console.WriteLine($"The amount of even numbers in array is: {evenCounter}");