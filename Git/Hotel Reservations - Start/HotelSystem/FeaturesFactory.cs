using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class FeaturesFactory
    {
        public Feature CreateLaundry()
        {
            return new Feature("Laundry", 5);
        }

        public Feature CreateWiFi()
        {
            return new Feature("WiFi", 0);
        }

        public Feature CreateAirConditioning()
        {
            return new Feature("Air Conditioning", 0);
        }

        public Feature CreateValetParking()
        {
            return new Feature("Valet Parking", 20);
        }

        public Feature CreatePool()
        {
            return new Feature("Pool", 0);
        }

        public Feature CreateSpa()
        {
            return new Feature("Spa", 50);
        }
    }
}
