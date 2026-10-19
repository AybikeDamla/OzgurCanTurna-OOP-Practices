//1 ile 100 arasındaki sayıları yazdırın; 3'e bölünenlerde “Fizz”, 5'e bölünenlerde “Buzz”, ikisine birden bölünenlerde
//“FizzBuzz” yazsın. (Klasik FizzBuzz)

using System;

for(int i = 1; i <=100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
