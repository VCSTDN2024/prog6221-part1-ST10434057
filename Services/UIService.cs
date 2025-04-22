using System.Xml.Linq;

namespace ST10434057_PROG6221_Part1_CyberAwareBot.Services
{
    public class UIService
    {
        public string GetUserName()
        {
            Console.WriteLine("Welcome user please enter your name: ");
            string? input = Console.ReadLine();
            Console.WriteLine($"\nWelcome, {input}! Let's talk cybersecurity.");
            return string.IsNullOrWhiteSpace(input) ? "No Name" : input;
        }
    }
}