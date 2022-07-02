// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Enter the number please: ");
string number = Console.ReadLine();

bool PolyOrNot(string num)
{
    return (num[0] == num[4] && num[1] == num[3]);
}

Console.WriteLine(PolyOrNot(number));