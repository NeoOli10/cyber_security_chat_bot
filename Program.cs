using System;

namespace cyber_security_chat_bot
{// start of the namespace
    public class Program
    {// start of the main program class
        static void Main(string[] args)
        {// create instances of the voice greeting and ASCII logo classes to display the greeting and logo
            new voice_greeting();
            new ascii_logo();

            //  create an instance of the welcome and username class to greet the user and collect their username
            welcome_and_username welcome_and_collect = new welcome_and_username();

            //  call the welcome and ask_user methods to greet the user and collect their username
            welcome_and_collect.welcome();
            welcome_and_collect.ask_user();

            //  check if the username is empty before proceeding
            prompt_and_search bot = new prompt_and_search();

            //  pass real username
            bot.aibot(welcome_and_collect.GetUsername());
        }// end of the main method
    }// end of the main program class
}// end of the namespace