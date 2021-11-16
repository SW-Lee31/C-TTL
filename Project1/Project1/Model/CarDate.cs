using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Model
{
    class CarDate
    {
        string carCondition;
        string carLocation;
        string carTime;

        public CarDate(string carCondition, string carLocation, string carTime)
        {
            this.carCondition = carCondition;
            this.carLocation = carLocation;
            this.carTime = carTime;
        }

        public string CarCondition { get => carCondition; set => carCondition = value; }
        public string CarLocation { get => carLocation; set => carLocation = value; }
        public string CarTime { get => carTime; set => carTime = value; }
    }
}
