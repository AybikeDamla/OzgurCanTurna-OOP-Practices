using System;
using System.Collections.Generic;
using System.Linq; // Average, Max and Min 

List<int> grades = new List<int>();

for (int i = 1; i <= 5; i++)
{
	Console.WriteLine($"Enter student {i}'s grade:");
	int.TryParse(Console.ReadLine(), out int grade);
	grades.Add(grade);
}

Console.WriteLine("\nStudent Grades:");
foreach (int grade in grades)
{
	Console.WriteLine(grade);
}

Console.WriteLine($"\nAverage Grade: {grades.Average()}");
Console.WriteLine($"Highest Grade: {grades.Max()}");
Console.WriteLine($"Lowest Grade: {grades.Min()}");