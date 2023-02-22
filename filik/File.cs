using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace filik
{
    class File
    {
        private string name;
        private string type;
        private DateTime time;


        public File(string name, DateTime time)
        {
            Name = name;
            Time = time;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                Regex reg = new Regex(@"(#;/\\)");
                if (!reg.IsMatch(value))
                {
                    string typ = value.Substring(value.LastIndexOf('.') + 1, value.Length - value.LastIndexOf('.') - 1);
                    string nam = value.Substring(0, value.Length - value.LastIndexOf('.') - 1);
                    Type = typ;
                    name = nam;
                }
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            private set
            {
                if (FileTypes.types.Contains(value))
                    type = value;
            }
        }

        public DateTime Time
        {
            get
            {
                return time;
            }
            set
            {
                if (value >= DateTime.Now)
                    time = value;
            }
        }
    }

    class FileLink : File
    {
        private string link;

        public FileLink(string name, DateTime time, string link) : base(name, time)
        {
            this.link = link;
        }
        public string Link
        {
            get
            {
                return link;
            }
            set
            {
                if (value.Contains("\\"))
                    link = value;
            }
        }
    }
}
