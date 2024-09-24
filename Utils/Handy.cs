using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastRDP.Utils
{
    public static class Handy
    {
        public static string[] stringSplitByNewline(string input)
        {
            return input.Split(Environment.NewLine);
        }
    }
}
