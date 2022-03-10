using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphysmExercise
{
    class Car : Vehicles
    {
        
        public Car(double fuelQuantity, double fuelConsuption, double fuelTank) : base(fuelQuantity, fuelConsuption, fuelTank)
        {
            FuelConsuptionLitersPerKm += 0.9;
        }

        public override void Drive(double distance)
        {
            double fuelNeedet = distance * FuelConsuptionLitersPerKm;
            if(fuelNeedet <= FuelQuantity)
            {
                Console.WriteLine($"Car travelled {distance} km");
                FuelQuantity -= fuelNeedet;
            }
            else
            {
                Console.WriteLine($"Car needs refueling");
                    
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
