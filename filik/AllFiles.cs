using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace filik
{
    static class AllFiles
    {
        public static List<File> allfiles { get; private set; }

        public static void init()
        {
            allfiles = new List<File>
            {
                new File("фур.png", DateTime.Now.AddMilliseconds(1000)),
                new File("чел.bmp", DateTime.Now),
                new File("filesr.jpg", DateTime.Now),
                new File("рофлотурик.png", DateTime.Now),
                new File("c--.jpg", DateTime.Now),
                new File("пробел.png", DateTime.Now)
            };
        }
    }
}
