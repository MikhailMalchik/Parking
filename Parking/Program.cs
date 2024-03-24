// See https://aka.ms/new-console-template for more information
using Parking;

static void Main(string[] args)
{
    Driver driver = new("Мишка","Мальчик");
    driver.AddCar("AE1101");
    Mall mall = new("Галерея");
    mall.AddParkingPlace(24);
    Park park = new(mall, driver, "AE11011");
    Console.WriteLine(park.ParkPlace); 

    Console.ReadLine();
}
