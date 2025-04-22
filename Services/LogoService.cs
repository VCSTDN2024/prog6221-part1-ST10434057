namespace ST10434057_PROG6221_Part1_CyberAwareBot.Services
{
    public class LogoService
    {
        public void DisplayLogo()
        {
            try
            {
                string logo = File.ReadAllText("Assets/ascii_logo.txt");
                Console.WriteLine(logo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("LogoService", ex);
            }
        }
    }
}