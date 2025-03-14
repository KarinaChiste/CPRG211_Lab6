using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Event
    {
        public int EventNumber {  get; set; }
        public string Location { get; set; }
        public string EventName { get; set; }

        public Event(int eventNumber, string location, string eventName)
        {
            EventNumber = eventNumber;
            Location = location;
            EventName = eventName;
        }
        public override string ToString()
        {
            return $"{EventNumber}\n{Location}\n{EventName}";
        }

        public void ReadFromFile()
        {
            string word = "Hackathon";
            StreamWriter sw = new StreamWriter("events.txt");
            sw.Write(word);
            
            sw.Close();
            using (FileStream fs = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "events.txt"), FileMode.OpenOrCreate, FileAccess.Read))
            {
                fs.Seek(0, SeekOrigin.Begin);
                byte[] buffer = new byte[1];
                fs.Read(buffer, 0, buffer.Length);
                Console.WriteLine($"In Word:{word}");
                string answer = System.Text.Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                Console.WriteLine($"The First Character is \"{answer[0]}\"");
                fs.Seek(4, SeekOrigin.Begin);
                fs.Read(buffer, 0, buffer.Length);
                string answer1 = System.Text.Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                Console.WriteLine($"The Middle Character is \"{answer1[0]}\"");
                fs.Seek(8, SeekOrigin.Begin);
                fs.Read(buffer, 0, buffer.Length);
                string answer2 = System.Text.Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                Console.WriteLine($"The Last Character is \"{answer2[0]}\"");
            }

        }
    }
}
