// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Решил поиграть с циклом do ... while
// Типа пусть пользователь реально вводит цифры с клавиатуры и пускай сохраняется массив введённых чисел
// Первый опыт. Прошу строго не судить :)

//Решение с массивом
Console.Write("Enter the number of digits please: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
int counter = 0;
int positiveAmount = 0;

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
    if (array[index] > 0) positiveAmount ++;
}

Console.WriteLine($"The sum of positive digits in Array is: {positiveAmount}");

// Решение без массива
Console.Write("Enter the number of digits please: ");
int amount = Convert.ToInt32(Console.ReadLine());
int counter = 0;
int sum = 0;
do
{
    Console.Write("Eneter your number please: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) sum++; 
    counter++;
} while (counter < amount);
Console.WriteLine($"Amount of positive numbers: {sum}");
