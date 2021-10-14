using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadLamp_Manufacture0909.Model
{
    class Process
    {
        string process_num;
        string fair_amount;
        string fail_amount;
        string condition;
        string temp;
        string humi;
        string dust;
        string time;


        public Process(string process_num, string condition, string temp, string humi, string dust, string time)
        {
            this.process_num = process_num;
            this.condition = condition;
            this.temp = temp;
            this.humi = humi;
            this.dust = dust;
            this.time = time;
        }

        public string Process_num { get => process_num; set => process_num = value; }
        public string Fair_amount { get => fair_amount; set => fair_amount = value; }
        public string Fail_amount { get => fail_amount; set => fail_amount = value; }
        public string Condition { get => condition; set => condition = value; }
        public string Temp { get => temp; set => temp = value; }
        public string Humi { get => humi; set => humi = value; }
        public string Dust { get => dust; set => dust = value; }
        public string Time { get => time; set => time = value; }
    }
}
