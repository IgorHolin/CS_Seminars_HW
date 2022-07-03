// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Тренирую функции


double PowerOf(int num, int power)
{
    double result = Math.Pow(num, power);
    return result;
}

Console.Write("Enter the base please: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the power please: ");
int pow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Number {number} in {pow} power gives us: {PowerOf(number,pow)}");
