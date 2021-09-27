using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0811.Model
{
    class SalesVo
    {
        string carName;
        int price;
        string insuDate;
        string custName;
        string custTel;
        string jupsuDate;
        string manager;

        public SalesVo(string carName, int price, 
            string insuDate, string custName, 
            string custTel, string jupsuDate, 
            string manager)
        {
            this.carName = carName;
            this.price = price;
            this.insuDate = insuDate;
            this.custName = custName;
            this.custTel = custTel;
            this.jupsuDate = jupsuDate;
            this.manager = manager;
        }

        public string CarName { get => carName; set => carName = value; }
        public int Price { get => price; set => price = value; }
        public string InsuDate { get => insuDate; set => insuDate = value; }
        public string CustName { get => custName; set => custName = value; }
        public string CustTel { get => custTel; set => custTel = value; }
        public string JupsuDate { get => jupsuDate; set => jupsuDate = value; }
        public string Manager { get => manager; set => manager = value; }
    }
}
