using System;

namespace HelperLibrary
{
    /// <summary>
    ///     This is a class, that helps you to create menu bar.
    /// </summary>
    public class Menu
    {
        public delegate void MenuDelegate();

        /// <summary>
        ///     Params - the array of MenuDelegates.
        /// </summary>
        /// <param name="delegateArr"></param>
        public static void StartMenu(MenuDelegate[] delegateArr)
        {
            var Option = 0;
            var Size = delegateArr.Length + 1;
            var options = new string[Size];

            for (var i = 0; i < Size - 1; i++) options[i] = $"{delegateArr[i].Method.Name}";

            //There may be an error. 
            options[^1] = "Exit";

            var promt = @"
 ▄████  ▒█████  ▓█████▄   ██████     ███▄ ▄███▓▓█████  ███▄    █  █    ██ 
 ██▒ ▀█▒▒██▒  ██▒▒██▀ ██▌▒██    ▒    ▓██▒▀█▀ ██▒▓█   ▀  ██ ▀█   █  ██  ▓██▒
▒██░▄▄▄░▒██░  ██▒░██   █▌░ ▓██▄      ▓██    ▓██░▒███   ▓██  ▀█ ██▒▓██  ▒██░
░▓█  ██▓▒██   ██░░▓█▄   ▌  ▒   ██▒   ▒██    ▒██ ▒▓█  ▄ ▓██▒  ▐▌██▒▓▓█  ░██░
░▒▓███▀▒░ ████▓▒░░▒████▓ ▒██████▒▒   ▒██▒   ░██▒░▒████▒▒██░   ▓██░▒▒█████▓ 
 ░▒   ▒ ░ ▒░▒░▒░  ▒▒▓  ▒ ▒ ▒▓▒ ▒ ░   ░ ▒░   ░  ░░░ ▒░ ░░ ▒░   ▒ ▒ ░▒▓▒ ▒ ▒ 
  ░   ░   ░ ▒ ▒░  ░ ▒  ▒ ░ ░▒  ░ ░   ░  ░      ░ ░ ░  ░░ ░░   ░ ▒░░░▒░ ░ ░ 
░ ░   ░ ░ ░ ░ ▒   ░ ░  ░ ░  ░  ░     ░      ░      ░      ░   ░ ░  ░░░ ░ ░ 
      ░     ░ ░     ░          ░            ░      ░  ░         ░    ░     
                  ░                                                               
 +-+-+ +-+-+-+-+-+
 |b|y| |A|C|C|I|O|
 +-+-+ +-+-+-+-+-+

Use arrow key to cycle through options.


";

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(promt);
                Console.ResetColor();
                for (var i = 0; i < Size; i++)
                {
                    if (Option == i) Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine($"{i}. {options[i]}");
                    if (Option == i) Console.ResetColor();
                }

                var KeyPressed = Console.ReadKey(true);
                if (KeyPressed.Key == ConsoleKey.DownArrow)
                    if (Option != Size - 1)
                        Option++;

                if (KeyPressed.Key == ConsoleKey.UpArrow)
                    if (Option != 0)
                        Option--;

                if (KeyPressed.Key == ConsoleKey.Enter)
                {
                    if (Option == Size - 1)
                    {
                        Environment.Exit(0);
                    }
                    else if (Option >= 0 && Option < Size)
                    {
                        Console.Clear();
                        delegateArr[Option]?.Invoke();
                        Console.ReadKey(true);
                    }
                }
            }
        }
    }
}