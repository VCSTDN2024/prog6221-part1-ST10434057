using System.Media;

namespace ST10434057_PROG6221_Part1_CyberAwareBot.Services
{
    public class AudioService
    {
        private const string SoundLocation = "Assets/greeting.wav";

        public void PlayGreeting()
        {
            try
            {
                using (var audioPlayer = new SoundPlayer(SoundLocation))
                {
                    audioPlayer.Play();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AudioService", ex);
            }
        }
    }
}
