using HelperLibrary;


namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            var delegates = new Menu.MenuDelegate[] {RUN};
            Menu.StartMenu(delegates);
        }

        static void RUN()
        {
            FirstTask aFirstTask = new FirstTask();
            aFirstTask.Running();


        }
    }
}
