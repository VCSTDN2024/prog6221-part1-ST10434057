namespace ST10434057_PROG6221_Part1_CyberAwareBot.Services
{
    public class ChatService
    {
        private readonly List<string> topicsToSearch = new List<string>
        {
            "How are you?",
            "Password",
            "Phishing",
            "Cyber Security",
            "Malware",
            "Firewall",
            "VPN",
            "2FA or Two-Factor Authentication",
            "Social Engineering",
            "Antivirus",
            "Update",
            "Ransomware",
            "Encryption"
        };

        public void StartChat()
        {
            Console.WriteLine("Welcome to CyberAwareBot!");
            ShowHelpList();

            bool chatBot = true;

            while (chatBot)
            {
                try
                {
                    Console.WriteLine("\nAsk a cybersecurity question (or type 'exit' to leave, 'list' to see topics again):");
                    string? input = Console.ReadLine()?.ToLower().Trim();
                    Console.WriteLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("I didn't catch that. Try again.");
                        continue;
                    }

                    if (input == "exit")
                    {
                        chatBot = false;
                        break;
                    }

                    if (input == "list")
                    {
                        ShowHelpList();
                        continue;
                    }

                    switch (input)
                    {
                        case var q when q.Contains("how are you"):
                            Console.WriteLine("I'm secure and happy. Let me know how I can help.");
                            break;
                        case var q when q.Contains("password"):
                            Console.WriteLine("Use a strong password with letters, numbers, and symbols.");
                            break;
                        case var q when q.Contains("phishing"):
                            Console.WriteLine("Phishing is dangerous. Never click suspicious links.");
                            break;
                        case var q when q.Contains("cyber security"):
                            Console.WriteLine("Cybersecurity is the practice of protecting computers, networks, and data from unauthorized access or attacks.");
                            break;
                        case var q when q.Contains("malware"):
                            Console.WriteLine("Malware is harmful software designed to damage or disrupt systems.");
                            break;
                        case var q when q.Contains("firewall"):
                            Console.WriteLine("A firewall acts like a security guard between your device and the internet.");
                            break;
                        case var q when q.Contains("vpn"):
                            Console.WriteLine("A VPN hides your IP address and encrypts your online activity for privacy.");
                            break;
                        case var q when q.Contains("2fa") || q.Contains("two-factor"):
                            Console.WriteLine("2FA adds an extra step to logging in, making your accounts more secure.");
                            break;
                        case var q when q.Contains("social engineering"):
                            Console.WriteLine("Social engineering tricks people into giving away personal info.");
                            break;
                        case var q when q.Contains("antivirus"):
                            Console.WriteLine("Antivirus software helps detect and remove harmful programs.");
                            break;
                        case var q when q.Contains("update"):
                            Console.WriteLine("Always keep your apps and devices updated to fix security holes.");
                            break;
                        case var q when q.Contains("ransomware"):
                            Console.WriteLine("Ransomware locks your files and demands money to unlock them.");
                            break;
                        case var q when q.Contains("encryption"):
                            Console.WriteLine("Encryption scrambles data so only authorized users can read it.");
                            break;
                        default:
                            Console.WriteLine("I couldn't understand that question. Try asking about topics like phishing, antivirus, or password safety.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Chat Service failure: " + ex.Message);
                }
            }

            Console.WriteLine("\nThanks for chatting!");
        }

        private void ShowHelpList()
        {
            Console.WriteLine("\nYou can ask about the following topics:");
            foreach (var topic in topicsToSearch)
            {
                Console.WriteLine($"- {topic}");
            }
        }
    }
}
