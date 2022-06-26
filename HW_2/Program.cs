// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

//По пренадлежности промежутку, булевским выражением True/False оформил.


Console.WriteLine("Enter the day number, please: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"You've chosen {day} of the week");

bool WeekendOrNot(int day)
{
    return (day > 5 && day <= 7);
}
Console.WriteLine(WeekendOrNot(day));