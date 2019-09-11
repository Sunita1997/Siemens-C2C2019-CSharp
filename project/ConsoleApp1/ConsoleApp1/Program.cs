using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirpath = @"C:\Users\joydip\source\repos\ConsoleApp1";
            FileSystemWatcher watcher = null;
            if (Directory.Exists(dirpath))
            {
                watcher = new FileSystemWatcher();
                watcher.Path = dirpath;
                watcher.Filter = "data.txt";
                var filepath = $@"{dirpath}\{watcher.Filter}";
                StreamReader streamReader = new StreamReader($"{filepath}\\datacopy.txt");
                StreamWriter writer = new StreamWriter($"{filepath}\\datacopy.txt", false);
                
                if (File.Exists(filepath))
                {
                    watcher.Changed += new FileSystemEventHandler(FileChanged);
                    watcher.Deleted += FileDeleted;
                    watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                    watcher.EnableRaisingEvents = true;

                }
            }
            Console.WriteLine("press enter to terminate the app...");
            Console.ReadLine();
        }

        private static void FileDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("file deleted");
        }

        private static void FileChanged(object sender, FileSystemEventArgs e)
        {
            //WaitForChangedResult result = (sender as FileSystemWatcher).WaitForChanged(WatcherChangeTypes.Changed);
            //Console.WriteLine(result.ChangeType.ToString());
            MessageBox.Show($"{e.Name} has been {e.ChangeType.ToString()}");
        }
    }
}
