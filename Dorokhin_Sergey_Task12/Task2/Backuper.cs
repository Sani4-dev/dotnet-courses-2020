using System;
using System.Globalization;
using System.IO;

namespace Task2
{
    public class Backuper
    {
        protected string _pathToBackup;
        protected string _pathToWatching;
        protected string _format;

        protected ICopyDelete CopyDeleter { get; set; }

        public Backuper(string pathToWatching, string pathToBackup, ICopyDelete copyDeleter, string format)
        {
            _pathToBackup = pathToBackup;
            _pathToWatching = pathToWatching;
            CopyDeleter = copyDeleter;
            _format = format;
        }

        public void DoBackupTo(DateTime dateTimeBackup)
        {
            string[] directoryes = Directory.GetDirectories(_pathToBackup);

            DateTime dateTimeToRestore = StringToDateTime(directoryes[0]);

            foreach (var directory in directoryes)
            {
                DateTime dateTimeDirectory = StringToDateTime(directory);

                if (dateTimeBackup > dateTimeDirectory)
                {
                    dateTimeToRestore = dateTimeDirectory;
                }
            }

            CopyDeleter.DeleteAllFiles(_pathToWatching);

            CopyDeleter.CopyAllFiles(Path.Combine(_pathToBackup, dateTimeToRestore.ToString(_format)), _pathToWatching);
        }

        protected DateTime StringToDateTime(string directoryName)
        {
            return DateTime.ParseExact(new DirectoryInfo(directoryName).Name, _format, CultureInfo.CurrentCulture);
        }
    }
}
