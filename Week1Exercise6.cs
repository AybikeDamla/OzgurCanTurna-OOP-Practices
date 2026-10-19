//Bir metin içindeki sesli harf sayısını bulan programı foreach ile yazın.
//

using System;
using System.Collections.Generic;

string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis varius nunc et quam volutpat, a interdum justo sagittis.";

int test = 0;

foreach (char c in text)
{
    if ("aeiouAEIOU".Contains(c))
        ++test;
    
}
Console.WriteLine($"The number of vowels in the text is: {test}");

//uygulama denetimi ilkesi yüzünden çalışmadı ama kod doğru, sonra tekrar bak.