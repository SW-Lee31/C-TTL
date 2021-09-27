using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0811.Model
{
    class HobbyVo
    {
        string hb1;
        string hb2;
        string hb3;
        string hb4;
        string hb5;
        string hb6;

        public HobbyVo(string hb1, string hb2, string hb3, 
            string hb4, string hb5, string hb6)
        {
            this.hb1 = hb1;
            this.hb2 = hb2;
            this.hb3 = hb3;
            this.hb4 = hb4;
            this.hb5 = hb5;
            this.hb6 = hb6;
        }

        public string Hb1 { get => hb1; set => hb1 = value; }
        public string Hb2 { get => hb2; set => hb2 = value; }
        public string Hb3 { get => hb3; set => hb3 = value; }
        public string Hb4 { get => hb4; set => hb4 = value; }
        public string Hb5 { get => hb5; set => hb5 = value; }
        public string Hb6 { get => hb6; set => hb6 = value; }
    }
}
