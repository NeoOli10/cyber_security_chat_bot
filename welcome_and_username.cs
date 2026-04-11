using System;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Imaging;
using System.Threading;

namespace cyber_security_chat_bot
{//start of the namespace
    public class welcome_and_username
    {//start of the class

        //global variable to store the username
        private string username = string.Empty;
        
        //method to welcome the user 

        public void welcome ()
        {
            
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("[Welcome to the Cyber Security Chat Bot!]");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("I am here to assist you with your cyber security needs.");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-------------------------------------------------------");


            Console.ResetColor();

        }

        //method to ask user for their username

        public void ask_user()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("BlueChatBot:");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("May I know your name?");

            Console.ResetColor();


            //loop until the user priovides a valid username
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("YOU: ");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                username = Console.ReadLine();

            } while (!empty());
        }

        // Boolean method to check if the username is empty or not

        private bool empty()
        {
            if (!string.IsNullOrWhiteSpace(username))
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("BlueChatBot: ");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Hello, "
                    + username +
                    "! It's nice to meet you.");

                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("BlueChatBot: ");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid name.");

                return false;


            }


        }
    }//end of the class
}//end of the namespace