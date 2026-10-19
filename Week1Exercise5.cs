using System;
using System.Collections.Generic;

//it didnt work, work on it later.

Dictionary<string, decimal> fiyatList = new Dictionary<string, decimal>
{
    ["keyboard"] = 1000,
    ["mouse"] = 700,
    ["monitor"] = 5000,
    ["kulaklık"] = 1500,
    ["defter"] = 50,
    ["kalem"] = 20,
    ["ajanda"] = 500,
    ["organizer"] = 300,
    ["ocak"] = 400,
    ["bardak"] = 100,
    ["tabak"] = 150,
    ["sandalye"] = 2000,
    ["masa"] = 3000,
    ["lamba"] = 2500
};

Console.WriteLine("Name the product to see it's price:");
string productName = Console.ReadLine() ?? "";

if (fiyatList.TryGetValue(productName, out decimal price))
{
    Console.WriteLine($"The price of {productName} is: {price} TL");
}
else
{
    Console.WriteLine($"Sorry, the product '{productName}' is not found in the list.");
}

