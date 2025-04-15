using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Intro
{
    public interface IVehicle
    {
        public string Type { get; }

        public string Color { get; }
    }

    public interface ISmartVehicle : IVehicle
    {
        public string BotType { get; }
    }

    public class Ship : IVehicle
    {
        public string Type { get => "Ship"; }
        public string Color { get; }

        public Ship(string color)
        {
            Color = color;
        }
    }

    public abstract class WheeledVehicle: IVehicle
    {
        public abstract string Color { get; }

        public abstract string Type { get; }

        protected int NumberOfWheels { get; }

        public string Hello()
        {
            return "hello";
        }

        //public abstract string INeedTobeImplemented();
    }

    public class Bicycle : WheeledVehicle
    {
        public override string Color
        {
            get
            {
                return "Blue";
            }
        }

        public override string Type => "Bicycle";

        public void Test()
        {
            base.Hello();
        }
    }

    public abstract class Car : WheeledVehicle
    {
        protected abstract string Model { get; }

        protected abstract string Manufacturer { get; }

        public abstract void Drive();

        public void Drive(int speed)
        {
            Console.WriteLine($"Driving a sedan car at {speed} km/h");
        }
    }

    public class SedanCar : Car, ISmartVehicle
    {
        public SedanCar()
        {
            _numberOfSeats = 5;
        }

        private int _numberOfSeats;

        public override string Color => "Red";

        public override string Type => "Sedan";

        protected override string Model => "Model 3";

        protected override string Manufacturer => "Tesla";

        public string BotType => "Bing Chat";

        public override void Drive()
        {
            Console.WriteLine("Driving a sedan car");

            Drive(100);
        }
    }

    public class HatchbackCar : Car
    {
        public override string Color => "Green";

        public override string Type => "Hatchback";

        protected override string Model => "Golf";

        protected override string Manufacturer => "Volkswagen";

        public override void Drive()
        {
            Console.WriteLine("Driving a hatchback car");
        }
    }

    public class Truck : Car
    {
        public override string Color => "Yellow";

        public override string Type => "Truck";

        protected override string Model => "F-150";

        protected override string Manufacturer => "Ford";

        public override void Drive()
        {
            Console.WriteLine("Driving a truck");
        }
    }

    private class Test
    {
        private string TestProperty { get; set; }
    }
}
