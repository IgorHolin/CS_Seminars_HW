// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Решил поиграть с циклом do ... while
// Типа пусть пользователь реально вводит цифры с клавиатуры
// Первый опыт. Прошу строго не судить :)


Console.Write("Enter the number of digits please: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
int counter = 0;
int positiveSum = 0;

do
{
    Console.Write("Eneter your number please: ");
    int num = Convert.ToInt32(Console.ReadLine());
    array[counter] = num;
    counter++;
} while (counter < arraySize);

Console.WriteLine($"Array: [{String.Join(",", array)}]");

for(int index = 0; index < arraySize; index++)
{
    if (array[index] > 0) positiveSum += array[index];
}

Console.WriteLine($"The sum of positive digits in Array is: {positiveSum}");