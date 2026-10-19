//Girilen bir sayının faktöriyelini for döngüsüyle hesaplayın. 20'den büyük sayılarda int yetmeyeceği için long
//kullanın.

long number;

Console.WriteLine("Enter a number to calculate it's factorial:");
number = long.Parse(Console.ReadLine());


	 static long CalculateFactorial(long num)
	{
		long factorial = 1;
		for (long i = 1; i <= num; i++)
		{
			factorial *= i;
		}
		return factorial;
	}


CalculateFactorial(number);
Console.WriteLine($"The factorial of {number} is: {CalculateFactorial(number)}");

