using System.Collections.Generic;

namespace cyber_security_chat_bot
{
    public class prompt_and_search
    {

        private List<string> questions = new List<string>()
        {
            "Hi",
            "How are you",
            "password security",
        };
        private List<string> answers = new List<string>()
        {
            "Hello there!",
            "I'm just a chatbot, but I'm doing great!",
            "To enhance password security, consider using a password manager to generate and store complex passwords, enable two-factor authentication for added protection, and regularly update your passwords to prevent unauthorized access." +


        };

        public void aibot(string Bluechatbot)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{Bluechatbot}:");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("How can I assist you today? (Type 'exit' to quit)");
            Console.ResetColor();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("YOU: ");
                string userInput = Console.ReadLine();
                Console.ResetColor();
                if (userInput.ToLower() == "exit")
                {
                    break;
                }
                bool foundAnswer = false;
                for (int i = 0; i < questions.Count; i++)
                {
                    if (userInput.ToLower().Contains(questions[i].ToLower()))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"{Bluechatbot}:");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(answers[i]);
                        Console.ResetColor();
                        foundAnswer = true;
                        break;
                    }
                }
                if (!foundAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{Bluechatbot}:");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("I'm sorry, I don't have an answer for that. Please try asking something else.");
                    Console.ResetColor();
                }
            }
        }
    }
}