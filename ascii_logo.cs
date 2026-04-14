using System;
using System.Drawing;
using System.IO;
using System.Security.Policy;

namespace cyber_security_chat_bot
{// start of the namespace
    public class ascii_logo
    {// start of the class
        public ascii_logo()
        {// start of the constructor
            ascii();
        }// end of the constructor

        private void ascii()
        {// start of the method
            try
            {// start to load and process the logo image
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mymylogo.png");

                if (!File.Exists(path)) return;

                Bitmap image = new Bitmap(path);

                int width = 120;
                int height = 60;
                Bitmap resized = new Bitmap(image, new Size(width, height));

                Console.ForegroundColor = ConsoleColor.DarkCyan;

                string asciiChars = "@#S%?*+;:,. ";

                for (int y = 0; y < resized.Height; y++)
                {// loop through each pixel in the resized image
                    for (int x = 0; x < resized.Width; x++)
                    {// get the pixel color and convert it to grayscale
                        Color pixel = resized.GetPixel(x, y);
                        int gray = (pixel.R + pixel.G + pixel.B) / 3;
                        int index = (gray * (asciiChars.Length - 1)) / 255;

                        Console.Write(asciiChars[index]);
                    }// new line after each row of pixels
                    Console.WriteLine();
                }// reset console color after printing the logo

                Console.ResetColor();
            }// catch any exceptions that occur while loading or processing the logo
            catch
            {// if there's an error, print an error message in red
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error loading logo.");
                Console.ResetColor();
            }
        }// end of the method
    }// end of class
}// end of the namespace