// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter M please: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N please: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumOf(int firstNum, int secondNum)
{
    if (firstNum == secondNum) return firstNum;
    return firstNum + SumOf(firstNum + 1, secondNum);
}
Console.Write(SumOf(M, N));