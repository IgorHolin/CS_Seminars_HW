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


// Решение №2
Console.Write("Enter the N number please: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

bool PolyOrNot(int num)
{
    return ((num%10) == (num/10000) && ((num/1000)%10 == (num%100)/10));
}

Console.WriteLine(PolyOrNot(N));
