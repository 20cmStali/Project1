using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Library
    {
        public string LName { set; get; }

        public string LAddress { set; get; }

        public int LYear { set; get; }

        public Library() { }

        public Library(string LName, string LAddress, int LYear)
        {
            LName = this.LName;
            LAddress = this.LAddress;
            LYear = this.LYear;
        }

    }
}
