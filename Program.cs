using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyber_security_chat_bot
{//start of the namespace
    public class Program
    {//start of the class
        static void Main(string[] args)
        {//start of main method

            //creating an instance for voice greeting
            //with a constructer

            new voice_greeting() { };



            //creating an instance for the asii_logo_class
            //with a constructer

            new ascii_logo() { };




            //creating an instance for the welcome_and_username class
            //with an object name welcome_and_collect
            welcome_and_username welcome_and_collect = new welcome_and_username();



            //calling the welcome_message method from the welcome_and_username class
            welcome_and_collect.welcome();



            //calling the ask_user method of the welcome_and_username class
            welcome_and_collect.ask_user();

            //creating an instance for the prompt_and_search class
            //with an object name bot
            prompt_and_search bot = new prompt_and_search();
            bot.aibot(Bluechatbot: "Bluechatbot");
















        }//end of main method
    }//end of the class
}//end of the namespace
