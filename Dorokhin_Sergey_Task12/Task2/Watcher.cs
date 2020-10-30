using System;
using System.IO;

namespace Task2
{
    public class Watcher
    {
        protected string _pathToWatching;
        protected string _pathToBackuping;
        protected string _format;

        protected ICopyDelete CopyDeleter { get; set; }

        public Watcher(string pathToWatching, string pathToBackuping, ICopyDelete copyDeleter, string format)
        {
            _pathToWatching = pathToWatching;
            _pathToBackuping = pathToBackuping;
            CopyDeleter = copyDeleter;
            _format = format;
        }

        public void Run()
        {
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = _pathToWatching;

                watcher.NotifyFilter = NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName;

                watcher.Filter = "*.txt";

                watcher.Changed += OnChanged;
                watcher.Created += OnChanged;
                watcher.Deleted += OnChanged;
                watcher.Renamed += OnChanged;

                watcher.EnableRaisingEvents = true;

                Console.WriteLine("Press 'q' to quit the sample.");
                while (Console.Read() != 'q') ;
            }
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            CopyDeleter.CopyAllFiles(_pathToWatching, CreatePointBackup());
        }

        protected string CreatePointBackup()
        {
            return Directory.CreateDirectory(Path.Combine(_pathToBackuping, DateTime.Now.ToString(_format))).FullName;
        }
    }
}
