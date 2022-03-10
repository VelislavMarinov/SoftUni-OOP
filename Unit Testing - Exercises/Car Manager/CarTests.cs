
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MakeShouldReturnAndExceptionIfEmptyl()
        {

            Assert.Throws<ArgumentException>(() => new Car("", "Seat", 2.0, 20));


        }
        [Test]
        public void MakeShouldReturnAndExceptionIfNull()
        {

            Assert.Throws<ArgumentException>(() => new Car(null, "Seat", 2.0, 20));


        }
        [Test]
        public void MakeShouldBeAddet()
        {
            Car car = new Car("Seat", "Toledo", 2, 20);
            
            Assert.AreEqual("Seat", car.Make);
        }
        [Test]
        public void ModelShouldReturnAndExceptionIfEmptyl()
        {

            Assert.Throws<ArgumentException>(() => new Car("eng", "", 2.0, 20));


        }
        [Test]
        public void ModelShouldReturnAndExceptionIfNull()
        {

            Assert.Throws<ArgumentException>(() => new Car("eng", null, 2.0, 20));


        }
        [Test]
        public void ModelShouldBeAddet()
        {
            Car car = new Car("Seat", "Toledo", 2, 20);

            Assert.AreEqual("Toledo", car.Model);
        }
        [Test]
        [TestCase(0)]
        [TestCase(-2)]
        public void FuelConsumptionShouldReturnAndExceptionIfNegative(int fuelConsumption)
        {


            Assert.Throws<ArgumentException>(() => new Car("Seat", "Toledo", fuelConsumption, 20));


        }
        [Test]
        [TestCase(0)]
        
        public void FuelConsumptionShouldReturnAndExceptionIfZero(int fuelConsumption)
        {


            Assert.Throws<ArgumentException>(() => new Car("Seat", "Toledo", fuelConsumption, 20));


        }



        [Test]
        [TestCase(0)]
        [TestCase(-2)]
        public void FuelCapacityShouldReturnAndExceptionIfNegative(int fuelCapacity)
        {


            Assert.Throws<ArgumentException>(() => new Car("Seat", "Toledo", 2, fuelCapacity));


        }
        [Test]
        [TestCase(-1)]
        
        
        public void RefuelShouldTrowAnExceptionIfValueIsFalse(double refuel)
        {
            Car car = new Car("Seat", "Toledo", 2, 20);

            Assert.Throws<ArgumentException>(() => car.Refuel(refuel));
        }
        [Test]
       
        [TestCase(0)]
        public void RefuelShouldTrowAnExceptionIfValueIsZero(double refuel)
        {
            Car car = new Car("Seat", "Toledo", 2, 20);

            Assert.Throws<ArgumentException>(() => car.Refuel(refuel));
        }

        [Test]
        

        public void DriveShouldTrowAnExceptionIfThereIsNotEnoughFuel()
        {
            Car car = new Car("Seat", "Toledo", 2, 20);

            Assert.Throws<InvalidOperationException>(() => car.Drive(100));
        }
        [Test]
       

        public void RefuelShouldNotPassTheCapacity()
        {
            Car car = new Car("Seat", "Toledo", 2, 20);
            car.Refuel(30);
            Assert.AreEqual(20, car.FuelAmount);
        }
        [Test]

        public void FuelAmaountShouldNotBeLessThanZero()
        {
            Car car = new Car("Seat", "Toledo", 2, 20);

            Assert.AreEqual(0, car.FuelAmount);
        }
        [Test]
        public void FuelCapacityShouldBeAdded()
        {
            Car car = new Car("Seat", "Toledo", 2, 20);
            Assert.AreEqual(20, car.FuelCapacity);
        }
        [Test]
        public void FuelConsumptionShouldBeAdded()
        {
            Car car = new Car("Seat", "Toledo", 2, 20);
            Assert.AreEqual(2, car.FuelConsumption);
        }




    }
}