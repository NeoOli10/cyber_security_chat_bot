using System;
using System.Collections.Generic;



namespace cyber_security_chatbott
{
    public class prompt_and_search
    {
        private List<string> questions = new List<string>()
        {
            "Hi",
            "How are you",
            "password security"
        };

        private List<string> answers = new List<string>()
        {
            "Hello there!",
            "I'm just a chatbot, but I'm doing great!",
            "Use strong passwords, enable 2FA, and never reuse passwords."
        };

        public void aibot(string username)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nHello {username}! How can I assist you? (type 'quit' to exit)");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{username}: ");

                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Goodbye {username}! Stay safe online 👋");
                    break;
                }

                bool found = false;

                for (int i = 0; i < questions.Count; i++)
                {
                    if (userInput.ToLower().Contains(questions[i].ToLower()))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("ChatBot: " + answers[i]);
                        found = true;
                        break;
                    }
                }

                // ✅ FIX: moved OUTSIDE loop
                if (!found)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ChatBot: I don't understand. Try something else.");
                }
            }

            Console.ResetColor();
        }
    }
}