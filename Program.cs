using System.Text.Json;

namespace Lab6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Event myEvent = new Event(1, "Calgary", "Tech Competition");

            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(myEvent, options);
            File.WriteAllText("event.txt", jsonString);

            var data = File.ReadAllText("event.txt");
            Event output = JsonSerializer.Deserialize<Event>(data);
            Console.WriteLine(output);

            myEvent.ReadFromFile();
            
        }
    }
}
