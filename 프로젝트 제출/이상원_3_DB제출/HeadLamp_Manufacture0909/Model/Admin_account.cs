using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadLamp_Manufacture0909.Model
{
    class Admin_account
    {
        string id;
        string pw;

        public Admin_account(string id, string pw)
        {
            this.id = id;
            this.pw = pw;
        }

        public string Id { get => id; set => id = value; }
        public string Pw { get => pw; set => pw = value; }
    }
}
