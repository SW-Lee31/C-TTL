using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadLamp_Manufacture0909.Model
{
    class Admin
    {
        string name;
        string digit;
        string addr;
        string enom;
        string level;

        public Admin(string name, string digit, string addr, string enom, string level)
        {
            this.name = name;
            this.digit = digit;
            this.addr = addr;
            this.enom = enom;
            this.level = level;
        }

        public string Name { get => name; set => name = value; }
        public string Digit { get => digit; set => digit = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Enom { get => enom; set => enom = value; }
        public string Level { get => level; set => level = value; }
    }
}
