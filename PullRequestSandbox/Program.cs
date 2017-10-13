// first line here




using System; // comment on first line
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullRequestSandbox
{
    class Program // x
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"..\..\text_with_zero.txt", "string with\u0000\nzero");
        }
    }
}

// another line to comment on
