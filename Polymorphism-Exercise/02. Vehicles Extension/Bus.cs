using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphysmExercise
{
    class Bus : Vehicles
    {
        public Bus(double fuelQuantity, double fuelConsuption, double _fuelTank) : base(fuelQuantity, fuelConsuption, _fuelTank)
        {

        }

        public void DriveWithoutPeople(double distance)
        {
            double fuelNeedet = distance * FuelConsuptionLitersPerKm;
            if (fuelNeedet <= FuelQuantity)
            {
                Console.WriteLine($"Bus travelled {distance} km");
                FuelQuantity -= fuelNeedet;
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");

            }
        }
        public override void Drive(double distance)
        {
           
            double fuelNeedet = distance * (FuelConsuptionLitersPerKm + 1.4);
            if (fuelNeedet <= FuelQuantity)
            {
                Console.WriteLine($"Bus travelled {distance} km");
                FuelQuantity -= fuelNeedet;
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");

            }
        }
        public override void Refuel(double litersToAdd)
        {
            if (litersToAdd <= 0)
            {
                Console.WriteLine($"Fuel must be a positive number");
            }
            else
            {
                double testFuel = FuelQuantity + litersToAdd;
                if (testFuel > FuelTank)
                {
                    Console.WriteLine($"Cannot fit {litersToAdd} fuel in the tank");
                }
                else
                {
                    FuelQuantity += litersToAdd;
                }
            }
            
        }
    }
}

