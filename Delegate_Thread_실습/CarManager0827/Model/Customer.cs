using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0827
{
    class Customer
    {
        string name;
        string tel;
        string addr;
        string date;
        string birth;
        string gender;
        List<string> hobbyList = new List<string>();

        public Customer(string name, string tel, string addr, 
            string date, string birth, 
            string gender, List<string> hobbyList)
        {
            this.name = name;
            this.tel = tel;
            this.addr = addr;
            this.date = date;
            this.birth = birth;
            this.gender = gender;
            this.hobbyList = hobbyList;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Date { get => date; set => date = value; }
        public string Birth { get => birth; set => birth = value; }
        public string Gender { get => gender; set => gender = value; }
        public List<string> HobbyList { get => hobbyList; set => hobbyList = value; }
    }
}
