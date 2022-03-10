using System;
namespace NeedForSpeed
{
    public class StartUp
    {
        public class Vehicle
        {
            public int HorsePower { get; set; }
            public double Fuel { get; set; }
            public virtual double DefaultFuelConsumption { get; set; } = 1.25;

            public virtual double FuelConsumption { get; set; } = 1.25;

            public Vehicle(int horsePower, double fuel)
            {
                this.HorsePower = horsePower;
                this.Fuel = fuel;

            }
            public void Drive(double kilometers)
            {
                Fuel -= FuelConsumption * kilometers;
            }
        }
        public class Motorcycle : Vehicle
        {
            public Motorcycle(int horsePower, double fuel) : base(horsePower,fuel)
            {
                

            }
        }

        public class RaceMotorcycle : Motorcycle
        {
            public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
            {


            }
            public override double DefaultFuelConsumption { get; set; } = 8;
            public override double FuelConsumption { get; set; } = 8;
        }
        public class CrossMotorcycle : Motorcycle
        {
            public CrossMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
            {


            }
        }
        public class Car : Vehicle
        {
            public Car(int horsePower, double fuel) : base(horsePower, fuel)
            {


            }
            public override double DefaultFuelConsumption { get; set; } = 3;
            public override double FuelConsumption { get; set; } = 3;
        }
        public class FamilyCar : Car
        {
            public FamilyCar(int horsePower, double fuel) : base(horsePower, fuel)
            {


            }
        }
        public class SportCar : Car
        {
            public override double DefaultFuelConsumption { get; set; } = 10;
            public override double FuelConsumption { get; set; } = 10;

            public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
            {


            }
        }
        public static void Main(string[] args)
        {
            
        }
    }
}
