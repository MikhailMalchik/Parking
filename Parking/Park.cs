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
        public Ticket ticket;
        public string Surname { get; set; }

        public List<CarsNumbers> CarsNumbers;

        public Park(Mall mall, Driver driver, string carNumber)
        {
            if (mall.parkings.Any(x=>x.parkingNumber.ContainsValue("Свободно")))
            {
                ParkPlace = mall.parkings.Where(x => x.parkingNumber.ContainsValue("Свободно")).First();
                ParkNumber =  ParkPlace.parkingNumber.Where(x => x.Value == "Свободно").First().Key ;
                ParkPlace.parkingNumber[ParkNumber] = "Занято";
                ticket = new(driver, carNumber, ParkNumber);
            }
            else throw new Exception("Нет свободных мест");
        }
    }
}
