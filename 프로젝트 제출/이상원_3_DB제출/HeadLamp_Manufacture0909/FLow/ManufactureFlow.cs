using HeadLamp_Manufacture0909.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadLamp_Manufacture0909.FLow
{
    class ManufactureFlow
    {
        static List<Inventory> pro_1_lst;

        static List<Inventory> pro_fail;

        static List<Inventory> pro_2_lst;

        static List<Inventory> pro_3_lst;

        static List<Inventory> pro_4_lst;

        static List<Inventory> pro_5_lst;

        static List<Inventory> complete_lst;

        public static List<Inventory> pro1_lst_Instance
        {
            get
            {
                if (pro_1_lst == null)
                {
                    pro_1_lst = new List<Inventory>();
                }
                return pro_1_lst;
            }
        }

        public static List<Inventory> pro_fail_Instance
        {
            get
            {
                if (pro_fail == null)
                {
                    pro_fail = new List<Inventory>();
                }
                return pro_fail;
            }
        }

        public static List<Inventory> pro2_lst_Instance
        {
            get
            {
                if (pro_2_lst == null)
                {
                    pro_2_lst = new List<Inventory>();
                }
                return pro_2_lst;
            }
        }

        public static List<Inventory> pro3_lst_Instance
        {
            get
            {
                if (pro_3_lst == null)
                {
                    pro_3_lst = new List<Inventory>();
                }
                return pro_3_lst;
            }
        }

        public static List<Inventory> pro4_lst_Instance
        {
            get
            {
                if (pro_4_lst == null)
                {
                    pro_4_lst = new List<Inventory>();
                }
                return pro_4_lst;
            }
        }

        public static List<Inventory> pro5_lst_Instance
        {
            get
            {
                if (pro_5_lst == null)
                {
                    pro_5_lst = new List<Inventory>();
                }
                return pro_5_lst;
            }
        }

        public static List<Inventory> complete_Instance
        {
            get
            {
                if (complete_lst == null)
                {
                    complete_lst = new List<Inventory>();
                }
                return complete_lst;
            }
        }
    }
}
