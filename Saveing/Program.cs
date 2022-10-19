using System.IO;
using System;
using System.Linq;
using System.Text.Json;


character C = new character();

Loading.Load(C);

while (true)
{
    string input = Console.ReadLine().ToLower();

    if (input == "ja")
    {
        Console.WriteLine("sparar");
        Saveing.Save(C);
    }
    if (input == "nej")
    {
        Console.WriteLine("sparar inte");
    }
    else
    {
        Console.WriteLine("måste vara ja eller nej ");
    }
}
