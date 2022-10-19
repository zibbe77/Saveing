using System;
using System.Text.Json;

public class character
{
    public string Name { get; set; }
    public string FileName { get; set; }
    public int Hapiness { get; set; }

    public character()
    {
        Name = "hiajsaj";
        Hapiness = 10;
    }
}
