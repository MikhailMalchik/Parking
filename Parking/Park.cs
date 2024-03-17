using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Park
    {
        public Mall mall { get; set; }
        public ParkingPlace ParkPlace { get; set; }
        public int ParkNumber {  get; set; }   

        public string Surname { get; set; }

        public List<CarsNumbers> CarsNumbers;

        public Park(Mall mall, Driver driver, string carNumber)
        {
            if (mall.parkings.Any(x => x.parkingNumber.Any(x => x == 0)))
            {
                ParkPlace = mall.parkings.Where(x => x.parkingNumber.Length>0).First();
                ParkNumber =  (ParkPlace.parkingNumber.Where(x => x == 0).First()) ;
                Ticket ticket = new(driver, carNumber, ParkNumber);
            }
            else throw new Exception("Нет свободных мест");
        }
    }
}
