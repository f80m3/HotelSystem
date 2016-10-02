using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class Feature
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public Feature(string name,double cost)
        {
            Name = name;
            Cost = cost;
        }

        public Feature()
        {
        }
    }
}
