using System;
using System.Collections.Generic;



namespace cyber_security_chat_bot
{// start of the namespace
    public class prompt_and_search
    {// start of the class
        private List<string> questions = new List<string>()
        {// list of keywords to match user input against
            "phishing",
            "password",
            "email",
            "link",
            "hi",
            "how are you",
            "can you please help me",
            "thanks"
        };// list of corresponding answers for each keyword

        private List<string> answers = new List<string>()
        {// answers corresponding to the keywords in the questions list
            " Phishing is when attackers trick you into giving personal information like passwords or banking details.",

            " Use strong passwords, enable 2FA, and never reuse passwords.",

            " Be careful with suspicious emails. Avoid clicking unknown links or downloading attachments.",

            " Never click suspicious links — they may steal your data or install malware.",

            " Hello! I'm your Cyber Security Assistant. How can I help you today?",

            " I'm doing great! I'm here to help you stay safe online.",

            " Of course! Tell me what you need help with.",

            " You're welcome! Stay safe online."
        };// method to start the chatbot interaction with the user

        public void aibot(string username)
        {// greet the user and explain how to use the chatbot
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n Hello " + username + "! I'm your Cyber Security Assistant.");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ask me about passwords, phishing, suspicious emails, or links.");
            Console.WriteLine("(type 'quit' to exit)\n");

            while (true)
            {// prompt the user for input
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(username + ": ");

                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                    continue;

                string input = userInput.ToLower();

                if (input == "quit")
                {// if the user types 'quit', exit the chatbot
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Goodbye " + username + "! Stay safe online.");
                    break;
                }// search for keywords in the user input and respond with the corresponding answer

                bool found = false;

                for (int i = 0; i < questions.Count; i++)
                {
                    //  exact match OR contains whole keyword safely
                    if (input == questions[i] || input.Contains(" " + questions[i]) || input.Contains(questions[i] + " "))
                    {// if a keyword is found in the user input, respond with the corresponding answer
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("BlueChatBot: " + answers[i]);
                        found = true;
                        break;
                    }// if the user input contains a keyword, respond with the corresponding answer
                }// if no keywords are found in the user input, provide a fallback response and suggest topics to ask about

                // fallback
                if (!found)
                {// if no keywords are found, provide a fallback response and suggest topics to ask about
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("BlueChatBot: I'm not sure I understand.");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("BlueChatBot: Try asking about:");

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(" - Password security");
                    Console.WriteLine(" - Phishing");
                    Console.WriteLine(" - Suspicious emails");
                    Console.WriteLine(" - Unsafe links");
                }// reset console color after each response
            }// end of the while loop

            Console.ResetColor();
        }// end of the method   
    }// end of the class
}// end of the namespace
