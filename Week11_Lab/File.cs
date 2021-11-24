using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Lab
{
    class File : Document
    {
        private string pathName;

        public string PathName { get => pathName; set => pathName = value; }

        public File(string pathName, string anyText) : base(anyText)
        {
            this.pathName = pathName;
        }

        public string toString()
        {
            return "Path [" + this.pathName + "] \nMessage : "+AnyText;
        }
    }
}
