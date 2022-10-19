using System.IO;
using System;
using System.Linq;
using System.Text.Json;

public class Saveing
{
    public static void Save(character C)
    {
        string jsonString = JsonSerializer.Serialize(C);
        File.WriteAllText(C.FileName + ".json", jsonString);
    }
}
