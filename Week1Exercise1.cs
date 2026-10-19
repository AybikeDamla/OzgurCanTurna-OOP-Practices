Console.WriteLine("Enter the first number:");
int.TryParse(Console.ReadLine(), out int firstNum);

Console.WriteLine("Enter the second number:");
int.TryParse(Console.ReadLine(), out int secondNum);

Console.WriteLine("Choose an operation:");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
int.TryParse(Console.ReadLine(), out int operation);

if (operation == 1)
{
    Console.WriteLine("Addition:");
    Console.WriteLine(firstNum + secondNum);
}
else if (operation == 2)
{
    Console.WriteLine("Subtraction:");
    Console.WriteLine(firstNum - secondNum);
}
else if (operation == 3)
{
    Console.WriteLine("Multiplication:");
    Console.WriteLine(firstNum * secondNum);
}
else if (operation == 4)
{
    if (secondNum != 0)
    {
        Console.WriteLine("Division:");
        Console.WriteLine((double)firstNum / secondNum);
    }
    else
        Console.WriteLine("Error: Division by zero is not allowed.");
}
else
{
    Console.WriteLine("Invalid operation selected.");
}