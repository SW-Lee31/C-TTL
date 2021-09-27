using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0811.Handler
{
    class MainLoginHandler
    {
        public bool loginchk(string id, string pw)
        {
            if (id == "guest" && pw == "1234")
            {
                return true;
            }
            return false;
        }
    }
}
