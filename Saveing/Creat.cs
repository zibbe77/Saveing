using System.IO;
using System;
using System.Linq;
using System.Text.Json;

public class Creat
{
    public static void Creating(character C)
    {
        Console.WriteLine("name");
        string input = "";
        bool notW = true;
        while (notW)
        {
            input = Console.ReadLine();
            if (input != "" && input.All(char.IsLetter))
            {
                notW = false;
            }
            else
            {
                Console.WriteLine("Bara bokstäder");
            }
        }

        File.Create($"{input}.json").Close();
        C.FileName = input;
        Saveing.Save(C);
    }
}
