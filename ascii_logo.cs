using System;
using System.Drawing;

namespace cyber_security_chat_bot
{//start of the namespace
    public class ascii_logo
    {//start of the class
        public ascii_logo()
        {//start of the constructor
            //call the method to display
            ascii();


        }//end of the constructor


        //ascii logo method
        private void ascii()
        {
            //path of the logo [get logo path]
            string path = string.Empty;

            //auto get the path of the logo
            string fullpath = AppDomain.CurrentDomain.BaseDirectory;

            //now combine the paths
            path = fullpath.Replace(@"bin\Debug\","mymylogo.png");

            Bitmap image = new Bitmap(path);

            //resize for better display and console fit
            //(image.height * width) / image.width;
            int width = 150;
            int height = 70;
            Bitmap resized = new Bitmap(image, new Size(width, height));

            //Default color for the ascii logo
            Console.ForegroundColor = ConsoleColor.Gray;
            String asciiChars = "!@#$%^&*()<>?,=-.";

            //start by the height of the image
            for (int y = 0; y < resized.Height; y++ )

            {
                //then width of the image
                for (int x = 0; x < resized.Width; x++)
                
                {
                    //color the pixel on x and y
                    Color pixel = resized.GetPixel(x, y);

                    //conevert to grayscale
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    //map grayscle to ascii 
                    int index = (gray * (asciiChars.Length - 1)) / 255;

                    Console.Write(asciiChars[index]);

                }
                Console.WriteLine();



            }

        }




    }//end of class
}//end of the namespace