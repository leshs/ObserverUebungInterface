using System;

namespace ObserverUebungInterface
{
    class Program : IFileAddedListener
    {
        Logger logger1 = new Logger("C:\\Users\\lschubert\\Documents\\log.txt");
        Logger logger2 = new Logger(Console.Out);
        FolderWatch watcher = new FolderWatch("C:\\Users\\lschubert\\Documents\\TestFolder");


        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();

        }


        public void Run()
        {
            watcher.FileAddedListeners.Add(this);

            //Test des Programms
            while (true)
            {
                
                string file = Console.ReadLine();
                watcher.FileAdded(file);
                
            }
        }

        public void NotifyFileAdded(string file)
        {
            logger1.WriteLine(file);
            logger2.WriteLine(file);           
        }

        
    }
}
