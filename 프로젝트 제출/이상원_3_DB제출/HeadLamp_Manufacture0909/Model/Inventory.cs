using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadLamp_Manufacture0909.Model
{
    class Inventory
    {
        string serial;
        string time;
        string process;
        string condition;

        public Inventory(string time, string process, string condition)
        {
            this.time = time;
            this.process = process;
            this.condition = condition;
        }

        public Inventory(string serial, string time, string process, string condition)
        {
            this.serial = serial;
            this.time = time;
            this.process = process;
            this.condition = condition;
        }

        public string Serial { get => serial; set => serial = value; }
        public string Time { get => time; set => time = value; }
        public string Process { get => process; set => process = value; }
        public string Condition { get => condition; set => condition = value; }
    }
}
