using System.Text.Json;
using DroneTest.Entities;

namespace DroneTest;

public class JsonUtils
{
    private JsonSerializerOptions options = new JsonSerializerOptions
    {
               
        WriteIndented = true
               
    };

    public void Write(Lists lists, string file)
    {
        var jsonString = JsonSerializer.Serialize(lists, options);
           
        File.WriteAllText(file,jsonString);
    }

    public Lists Read(string file)
    {
        var libraryIn = File.ReadAllText((file));
        return JsonSerializer.Deserialize<Lists>(libraryIn);
    }
    
}