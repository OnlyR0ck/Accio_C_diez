using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HelperLibrary;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            var delegates = new Menu.MenuDelegate[] {PlayNotes,RUN };
            Menu.StartMenu(delegates);
        }

        static void PlayNotes()
        {
            var fr = new float[]{ 659.255f, 659.255f, 659.255f, 523.251f, 659.255f, 783.991f, 391.995f, 523.251f, 391.995f, 329.628f, 440, 493.883f, 466.164f, 440, 391.995f, 659.255f, 783.991f, 880, 698.456f, 783.991f, 659.255f, 523.251f, 587.33f, 987.767f, 783.991f, 680.255f, 698.456f, 622.254f, 680.255f, 415.305f, 466.164f, 523.251f, 440, 523.251f, 587.33f, 783.991f, 739.989f, 729.989f, 587.33f, 659.255f, 1046.502f, 1046.502f, 1046.502f };
            var dur = new int[]{ 300, 300, 160, 160, 300, 300, 300, 300, 300, 300, 300, 300, 160, 300, 300, 300, 300, 300, 160, 160, 300, 160, 160, 160, 300, 300, 160, 300, 160, 300, 300, 300, 300, 300, 300, 300, 300, 160, 300, 300, 300, 160, 300 };
            var del = new int[]{ 35, 35, 50, 35, 35, 350, 200, 35, 35, 200, 35, 35, 35, 200, 35, 35, 35, 35, 35, 200, 35, 35, 35, 35, 35, 35, 35, 35, 200, 35, 35, 35, 35, 35, 200, 35, 35, 35, 35, 200, 35, 35, 0 };
            List<Notes> notes = new List<Notes>();
            for (int i = 0; i < fr.Length; i++)
            {
                notes.Add(new Notes((int) fr[i], dur[i], del[i]));
            }

            for (int i = 0; i < fr.Length; i++)
            {
                notes[i].DisposeAsync();
            }

            string bigText = @" 
 ___                                                                   ___                        
(  _`\                               /'\_/`\              _           (  _`\                      
| (_(_) _   _  _ _      __   _ __    |     |   _ _  _ __ (_)   _      | (_) ) _ __   _     ___    
`\__ \ ( ) ( )( '_`\  /'__`\( '__)   | (_) | /'_` )( '__)| | /'_`\    |  _ <'( '__)/'_`\ /',__)   
( )_) || (_) || (_) )(  ___/| |      | | | |( (_| || |   | |( (_) )   | (_) )| |  ( (_) )\__, \ _ 
`\____)`\___/'| ,__/'`\____)(_)      (_) (_)`\__,_)(_)   (_)`\___/'   (____/'(_)  `\___/'(____/(_)
              | |                                                                                 
              (_)                                                                                 ";

            ConsoleColor[] colors =
                {ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue,ConsoleColor.DarkBlue,ConsoleColor.DarkMagenta};

            for (int i = 0,j = 0;i<bigText.Length;i++, j++)
            {
                if (j == colors.Length - 1) j = 0;
                Console.ForegroundColor = colors[j];
                Console.Write(bigText[i]);
            }

        }

        static void RUN()
        {
            FirstTask aFirstTask = new FirstTask();
            aFirstTask.Running();
        }
    }
}
