Console.Write("Enter 1st number: ");
int firstN = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2nd number: ");
int secondN = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 3rd number: ");
int thirdN = Convert.ToInt32(Console.ReadLine());
if ( firstN > secondN && firstN > thirdN)
{
    Console.Write(firstN);
}
if ( secondN > firstN && secondN > thirdN)
{
    Console.Write(secondN);
}
if (thirdN > firstN && thirdN > secondN)
{
    Console.Write(thirdN);
}
