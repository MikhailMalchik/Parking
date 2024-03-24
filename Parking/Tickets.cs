using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Ticket
    {
        public DateTime Time { get; set; }
        public Mall mall { get; set; }
        public int ParkingPlace { get; set; }
        public Driver Driver { get; set; }
        public string CarNumber { get; set; }
        public Ticket(Driver driver, string carNumber, int parknumber)
        {
            Time = DateTime.Now;
            Driver = driver;
            ParkingPlace = parknumber;
            if (Driver.CarsNumbers.Exists(x=>x.Number==carNumber)) 
            { CarNumber = carNumber;
   
            }
            else { throw new Exception("Такого номера автомобиля не существует у данного водителя"); }
        }
       
    }
    public class CarsNumbers1
    {
        public string Number { get; set; }
        public CarsNumbers1(string number)
        {
            Number = number;
        }
    }
   
}
