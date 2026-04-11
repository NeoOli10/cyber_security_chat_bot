using System;
using System.IO;
using System.Media;

namespace cyber_security_chat_bot
{//start of the namespace
    internal class voice_greeting
    {//start of the class
        public voice_greeting()
        {//start of the constructor
            //call the method to play the voice greeting

            greet();


        }//end of the constructor
        // method to play the voice

        private void greet() { //start of method

            //auto get the path of the voice greeting recording
            string path = AppDomain.CurrentDomain.BaseDirectory;

            //then rename the path to the voice greeting recording

            string fullpath = path.Replace(@"bin\Debug\", "voicegreeting.wav");

            //load the audio file , then play the audio file after instance
            SoundPlayer voice_play = new SoundPlayer(fullpath);

            //load the audio file 
            voice_play.Load();

            //then play the audio file
            voice_play.Play();
           
            //
        
        }//end of method



    }//end of the class
}//end of the namespace