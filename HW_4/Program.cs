// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Функции функции, практикуюсь :)

int sumOf(int num)
{
    int result = 0;
    while (num / 10 != 0)
    {
        result = result + (num % 10);
        num = num / 10;
    }
    return result + num%10;
}

Console.Write("Enter the number please: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of digits in {number} is: {sumOf(number)}");