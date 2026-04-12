using System;

namespace cyber_security_chat_bot
{
    public class Program
    {
        static void Main(string[] args)
        {
            new voice_greeting();
            new ascii_logo();

            welcome_and_username welcome_and_collect = new welcome_and_username();

            welcome_and_collect.welcome();
            welcome_and_collect.ask_user();

            prompt_and_search bot = new prompt_and_search();

            // ✅ FIX: pass real username
            bot.aibot(welcome_and_collect.GetUsername());
        }
    }
}