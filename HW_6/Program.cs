// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = varOne * x + varTwo, y = varThree * x + varFour
// значения varTwo, varOne, varFour и varThree задаются пользователем.

// varTwo = 2, varOne = 5, varFour = 4, varThree = 9 -> (-0,5; -0,5)

Console.Write("Enter varOne please: ");
double varOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter varTwo please: ");
double varTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter varThree please: ");
double varThree = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter varFour please: ");
double varFour = Convert.ToInt32(Console.ReadLine());

double xPoint = (varFour - varTwo) / (varOne - varThree);
double yPoint = (varOne * varFour - varThree * varTwo) / (varOne - varThree);

Console.WriteLine($"Formmulas look like following: 1) y = {varOne}x + {varTwo} & 2) y = {varThree}x + {varFour}");

if (varOne == varThree)
{
    if (varTwo == varFour) Console.WriteLine("These lines coincide!"); // совпадение прямых
    else if (varFour != varTwo) Console.WriteLine("No intersections here."); // нет точек пересечения 
}    
else Console.WriteLine($"The point of intersection is: ({Math.Round(xPoint, 2)}; {Math.Round(yPoint, 2)})");