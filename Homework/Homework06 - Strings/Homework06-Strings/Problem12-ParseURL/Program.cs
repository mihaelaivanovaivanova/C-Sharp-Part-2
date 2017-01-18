using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12_ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            string protocol = url.Substring(0, url.IndexOf(":"));
            string server = url.Substring(protocol.Length + 3, (url.IndexOf(@"/",protocol.Length+3)-protocol.Length-3));
            string resource = url.Remove(0, protocol.Length + 3 + server.Length);
            Console.WriteLine("[protocol] = "+ protocol);
            Console.WriteLine("[server] = "+server);
            Console.WriteLine("[resource] = "+resource);
        }
    }
}
