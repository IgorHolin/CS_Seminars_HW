// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Enter 'm' please: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 'n' please: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int firstNum, int secondNum)
{
    if (firstNum == 0) return secondNum + 1;
    else if (secondNum == 0 && firstNum > 0) return Akkerman(firstNum - 1, 1);
    return Akkerman(firstNum -1, Akkerman(firstNum, secondNum-1));
}
Console.Write(Akkerman(m,n));