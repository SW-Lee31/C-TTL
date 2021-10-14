using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadLamp_Manufacture0909.Model
{
    class Del
    {
        string del_seq;
        string mem_seq;
        string inv_seq;
        string curr_loc;
        string dest_loc;
        string admin_seq;
        string del_con;

        public Del(string mem_seq, string inv_seq, string curr_loc, 
            string dest_loc, string admin_seq)
        {
            this.mem_seq = mem_seq;
            this.inv_seq = inv_seq;
            this.curr_loc = curr_loc;
            this.dest_loc = dest_loc;
            this.admin_seq = admin_seq;
        }

        public Del(string del_seq, string mem_seq, string inv_seq,
            string curr_loc, string dest_loc, string admin_seq, string del_con)
        {
            this.del_seq = del_seq;
            this.mem_seq = mem_seq;
            this.inv_seq = inv_seq;
            this.curr_loc = curr_loc;
            this.dest_loc = dest_loc;
            this.admin_seq = admin_seq;
            this.del_con = del_con;
        }

        public string Del_seq { get => del_seq; set => del_seq = value; }
        public string Mem_seq { get => mem_seq; set => mem_seq = value; }
        public string Inv_seq { get => inv_seq; set => inv_seq = value; }
        public string Curr_loc { get => curr_loc; set => curr_loc = value; }
        public string Dest_loc { get => dest_loc; set => dest_loc = value; }
        public string Admin_seq { get => admin_seq; set => admin_seq = value; }
        public string Del_con { get => del_con; set => del_con = value; }
    }
}
