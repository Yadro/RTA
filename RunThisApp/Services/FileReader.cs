using System.IO;
using System.Text;

namespace RunThisApp.Services
{
    public class FileReader : IReadWrite
    {
        private readonly string path;

        public FileReader(string path)
        {
            this.path = path;
        }

        public string Read()
        {
            if (!File.Exists(this.path))
            {
                throw new FileNotFoundException("File not found", this.path);
            }

            return File.ReadAllText(this.path, Encoding.UTF8);
        }

        public void Write()
        {
            throw new System.NotImplementedException();
        }
    }
}