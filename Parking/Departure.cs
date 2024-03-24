using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public  class Departure
    {
        public TimeSpan parktime; 
        
        public Departure(Park park,Mall mall)
        {
            if (park.ticket != null)
            {
                parktime = (DateTime.Now - park.ticket.Time).Duration();
                var parkplace = mall.parkings.SingleOrDefault(x => x.parkingNumber == park.ParkPlace.parkingNumber);
                parkplace.parkingNumber[park.ParkNumber] = "Свободно";
                Console.WriteLine($"{parktime.Days} {parktime.Hours} {parktime.Minutes}");
            }
            else throw new Exception("Вы не парковались");
        }
    }
}
