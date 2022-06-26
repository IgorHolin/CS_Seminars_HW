// Задача 10: Напишите программу,
// которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

//Знаю что можно без функции, но балуюсь, чтобы закрепить материал :)


int number = new Random().Next(100, 1000);
Console.WriteLine($"Your number is: {number}");

int SecondNumber(int number)
{
    int answer = (number / 10) % 10;
    return answer;
}

Console.WriteLine($"The middle number of {number} is {SecondNumber(number)}");