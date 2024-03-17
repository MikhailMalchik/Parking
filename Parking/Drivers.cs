using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Driver
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<CarsNumbers> CarsNumbers;

        public Driver(string name, string surname)
        {
            Name = name;
            Surname = surname;
            CarsNumbers = new List<CarsNumbers>();
        }
        public void AddCar(string number)
        {
            if(CarsNumbers.Any(x=>x.Number== number))
            {
                throw new Exception("Такой номер автомобиля уже существует");
            }
            CarsNumbers.Add(new CarsNumbers(number));

        }
    }
    public class CarsNumbers
    {
        public string Number { get; set; }
        public CarsNumbers(string number)
        {
            Number = number;
        }
    }
}
