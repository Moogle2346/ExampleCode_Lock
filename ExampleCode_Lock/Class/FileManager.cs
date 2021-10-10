using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ExampleCode_Lock.Class
{
    public class FileManager
    {
        private string FilePath;
        private object LockObject = new object();

        public FileManager()
        {
            FilePath = "output.txt";
        }

        public FileManager(string path)
        {
            FilePath = path;
        }

        public bool Write(string text)
        {
            lock (this)
            {
                using (StreamWriter sw = new StreamWriter(FilePath, true))
                {
                    sw.WriteLine(text);
                }
            }
            return true;
        }

        public string ViewOpenFileDialog()
        {
            string ans = string.Empty;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "ファイルを開く";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ans = ofd.FileName;
                }
            }

            return ans;
        }
    }
}
