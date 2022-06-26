// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

//Балуюсь с функциями :)


int number = new Random().Next(100, 1000);
Console.WriteLine($"Your number is: {number}");

int SecondNumber(int number)
{
    int answer = (number / 10) % 10;
    return answer;
}
Console.WriteLine($"The second number in {number} is {SecondNumber(number)}");