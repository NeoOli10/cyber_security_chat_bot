using System;

namespace cyber_security_chat_bot
{
    public class welcome_and_username
    {
        private string username = string.Empty;

        public void welcome()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("=======================================================");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     WELCOME TO THE CYBER SECURITY CHAT BOT");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("=======================================================");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" I am here to assist you with your cyber security needs.");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("=======================================================");

            Console.WriteLine();
            Console.ResetColor();
        }

        public void ask_user()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("BlueChatBot:");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("What is your name?");

            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("YOU: ");

                username = Console.ReadLine();

            } while (!empty());
        }

        private bool empty()
        {
            if (!string.IsNullOrWhiteSpace(username))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("BlueChatBot: ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hello, " + username + "! Nice to meet you.");

                Console.WriteLine();
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid name.");
                return false;
            }
        }

        public string GetUsername()
        {
            return username;
        }
    }
}