using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Model
{
    class ItemsData
    {
        string aItems;
        string bItems;
        string completeItems;
        string itmesTime;

        public ItemsData(string aItems, string bItems, string completeItems, string itmesTime)
        {
            this.aItems = aItems;
            this.bItems = bItems;
            this.completeItems = completeItems;
            this.itmesTime = itmesTime;
        }

        public string AItems { get => aItems; set => aItems = value; }
        public string BItems { get => bItems; set => bItems = value; }
        public string CompleteItems { get => completeItems; set => completeItems = value; }
        public string ItmesTime { get => itmesTime; set => itmesTime = value; }
    }
}
