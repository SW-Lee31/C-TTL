using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadLamp_Manufacture0909.Model
{
    class DataInstance
    {
        string time;
        string pro_1_temp;
        string pro_1_humi;
        string pro_1_dust;
        string pro_2_temp;
        string pro_2_humi;
        string pro_2_dust;
        string pro_3_temp;
        string pro_3_humi;
        string pro_3_dust;
        string pro_4_temp;
        string pro_4_humi;
        string pro_4_dust;
        string pro_5_temp;
        string pro_5_humi;
        string pro_5_dust;

        public DataInstance(string time, string pro_1_temp, string pro_1_humi, string pro_1_dust, 
            string pro_2_temp, string pro_2_humi, string pro_2_dust)
        {
            this.time = time;
            this.pro_1_temp = pro_1_temp;
            this.pro_1_humi = pro_1_humi;
            this.pro_1_dust = pro_1_dust;
            this.pro_2_temp = pro_2_temp;
            this.pro_2_humi = pro_2_humi;
            this.pro_2_dust = pro_2_dust;
        }

        public string Pro_1_temp { get => pro_1_temp; set => pro_1_temp = value; }
        public string Pro_1_humi { get => pro_1_humi; set => pro_1_humi = value; }
        public string Pro_1_dust { get => pro_1_dust; set => pro_1_dust = value; }
        public string Pro_2_temp { get => pro_2_temp; set => pro_2_temp = value; }
        public string Pro_2_humi { get => pro_2_humi; set => pro_2_humi = value; }
        public string Pro_2_dust { get => pro_2_dust; set => pro_2_dust = value; }
        public string Time { get => time; set => time = value; }
    }
}
