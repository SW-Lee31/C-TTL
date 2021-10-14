using HeadLamp_Manufacture0909.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadLamp_Manufacture0909.Adapter
{
    class BaseAdapter
    {
        static List<Admin_account> act_lst;

        static List<Inventory> inv_lst;

        static List<DataInstance> data_lst;

        static List<Member> mem_lst;

        static List<Admin> ad_lst;

        static List<Del> del_lst;

        public static List<Admin_account> act_lst_Instance
        {
            get
            {
                if (act_lst == null)
                {
                    act_lst = new List<Admin_account>();
                }
                return act_lst;
            }
        }

        public static List<Inventory> inv_lst_Instance
        {
            get
            {
                if (inv_lst == null)
                {
                    inv_lst = new List<Inventory>();
                }
                return inv_lst;
            }
        }

        public static List<DataInstance> data_lst_Instance
        {
            get
            {
                if (data_lst == null)
                {
                    data_lst = new List<DataInstance>();
                }
                return data_lst;
            }
        }

        public static List<Member> mem_lst_Instance
        {
            get
            {
                if (mem_lst == null)
                {
                    mem_lst = new List<Member>();
                }
                return mem_lst;
            }
        }

        public static List<Admin> ad_lst_Instance
        {
            get
            {
                if (ad_lst == null)
                {
                    ad_lst = new List<Admin>();
                }
                return ad_lst;
            }
        }

        public static List<Del> del_lst_Instance
        {
            get
            {
                if (del_lst == null)
                {
                    del_lst = new List<Del>();
                }
                return del_lst;
            }
        }
    }
}
