using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Mall
    {
        public string Name { get; set; }
        public List<ParkingPlace> parkings;
        public Mall(string n)
        {
            Name = n;
            parkings = new List<ParkingPlace>();
        }
        public void AddParkingPlace(int capacity)
        {
            parkings.Add(new ParkingPlace(capacity));
        }
    }
    public class ParkingPlace
    {
        public int Capacity { get; set; }
        public ParkingPlace(int capacity )
    {
        Capacity = capacity;
    }
    }


}
