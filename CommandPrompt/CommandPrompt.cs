using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPrompt
{
    class CommandPrompt
    {
        // unknownType backgroundColor;
        // unknownType foregroundColor;
        string[] screenText;
        int height;
        int columns;

        //this is the command prompt constructor
        public CommandPrompt(int height, int columns)
        {
            this.height = height;
            this.columns = columns;

            // set the backgroundColor to some default
            // set the foregroundColor to some default
            // create the screen to hold the number of rows passed in with the height parameter
            screenText = new string[height];

            // we will use the C# object to set the size of our window.
            Console.SetWindowSize(columns, height + 10);

            // let's set the initial screen rows to all blank lines
            for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i] = "";
            }
        }

        //this is a display command prompt method
        public void Display()
        {
            // set the foreground and background colors
            Console.Clear();             //the Console object is available to us to control aspects of our terminal window. 
                                         //The Clear method will blank our window
                                         //The Clear method has blanked the screen and left the cursor at the top of the window.
                                         //We will now loop through the screenText array to put out text on the screen.
            for (int i = 0; i < screenText.Length; i++)
            {
                Console.WriteLine(screenText[i]);
            }
        }
        //this method sets the screen text of a line number
        public void SetScreenText(int lineNumber, string lineText)
        {
            screenText[lineNumber] = lineText;
        }
    }
}
