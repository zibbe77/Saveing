using System;
using System.IO;
using System.Linq;
using System.Text.Json;


public class Loading
{
    public static void Load(character C)
    {
        string[] files = Directory.GetFiles(".");
        List<string> jsonFiles = files.Where(f => Path.GetExtension(f) == ".json").ToList();
        foreach (var file in jsonFiles)
        {
            Console.WriteLine(file);
        }

        if (jsonFiles.Count == 0)
        {
            Creat.Creating(C);
        }
        else
        {
            Console.WriteLine("skriv för att ladda in");
            string input = Console.ReadLine();
            MyDeserialize(C, input);
        }

    }

    public static void MyDeserialize(character C, string fileRead)
    {
        string jsonString = File.ReadAllText(fileRead);
        C = JsonSerializer.Deserialize<character>(jsonString);
    }


}
