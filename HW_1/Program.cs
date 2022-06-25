Console.Write("Enter first number: ");
int firstN = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int secondN = Convert.ToInt32(Console.ReadLine());
    if (firstN > secondN)
    {
        Console.WriteLine("First number is bigger: ");
        Console.Write("max = ");
        Console.WriteLine(firstN);
    }
    else
    {
        Console.WriteLine("Second number is bigger");
        Console.Write("max = ");
        Console.WriteLine(secondN); 
    }