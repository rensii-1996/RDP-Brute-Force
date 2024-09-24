using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastRDP.Utils
{
    public static class FileUtils
    {
        public static string[] readFile(string path)
        {
            try
            {
                return File.ReadAllLines(path);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static bool writeLinesToFile(string[] input, string fileName)
        {
            try
            {
                File.WriteAllLines(fileName, input);
                return true;
            }catch(Exception _)
            {
                return false;
            }
        }
    }
}
