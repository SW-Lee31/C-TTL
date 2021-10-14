using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadLamp_Manufacture0909.Model
{
    class Member
    {
        string mem_seq;
        string name;
        string dest;

        public Member(string mem_seq, string name, string dest)
        {
            this.mem_seq = mem_seq;
            this.name = name;
            this.dest = dest;
        }

        public string Mem_seq { get => mem_seq; set => mem_seq = value; }
        public string Name { get => name; set => name = value; }
        public string Dest { get => dest; set => dest = value; }
    }
}
