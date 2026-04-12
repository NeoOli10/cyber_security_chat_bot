using System;
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
            "To enhance password security, consider using a password manager to generate and store complex passwords, enable two-factor authentication for added protection, and regularly update your passwords to prevent unauthorized access."


        };
        public void aibot(string username)
        {
            Console.WriteLine("Hello " + username + "! How can I assist you today? (type 'quit' to exit) ");

            while (true)
            { Console.Write(username + ": ");
                string userInput = Console.ReadLine();

                if (userInput == "quit")
                {
                    Console.WriteLine("Goodbye " + username + "! Have a great day!");
                    break;
                }

                bool found = false;

                for (int i = 0; i < questions.Count; i++)
                {
                    if (userInput.Contains(questions[i]))

                    {
                        Console.WriteLine("Chatbot: " + answers[i]);
                        found = true;
                        break;
                    }
                if (!found)
                    {
                        Console.WriteLine("Chatbot: I'm sorry, I don't have an answer for that. Can you please rephrase your question or ask something else?");
                    }


                }

            }


        }
    }
}