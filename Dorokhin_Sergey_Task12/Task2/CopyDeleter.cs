using System.IO;

namespace Task2
{
    public class CopyDeleter : ICopyDelete
    {
        public void CopyAllFiles(string from, string to)
        {
            string[] files = Directory.GetFiles(from);

            foreach (var file in files)
            {
                File.Copy(file, Path.Combine(to, Path.GetFileName(file)), true);
            }
        }

        public void DeleteAllFiles(string path)
        {
            string[] files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                File.Delete(file);
            }
        }
    }
}
