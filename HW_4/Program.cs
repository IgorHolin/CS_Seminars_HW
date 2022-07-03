// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Попробовал заполняшки с рандомом через void-функции


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 1000);
}

void PrintArray(int[] arr)
{
    Console.WriteLine($"[{String.Join(",", arr)}]");
}
  
Console.Write("Enter the number of digits in array please: ");
int amount = Convert.ToInt32(Console.ReadLine());
int[] newArr = new int[amount];

FillArray(newArr);
PrintArray(newArr);