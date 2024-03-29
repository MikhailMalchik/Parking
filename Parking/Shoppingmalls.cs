﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public Dictionary<int, string> parkingNumber;

        public ParkingPlace(int capacity )
        {
            parkingNumber = new Dictionary<int, string>();
            for (int j = 0; j < capacity; j++)
            {
                parkingNumber.Add(j, "Свободно");
            }
        }
    }


}
