using ST10434057_PROG6221_Part1_CyberAwareBot.Services;

namespace ST10434057_PROG6221_Part1_CyberAwareBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AudioService audio = new();
                LogoService logo = new();
                UIService ui = new();
                ChatService chat = new();

                audio.PlayGreeting();
                logo.DisplayLogo();
                string name = ui.GetUserName();
                chat.StartChat();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
