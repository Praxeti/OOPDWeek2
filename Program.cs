using System;

namespace OOPDWeek2_Vehicles
{

     public class Vehicles
    {      
            string make;

            public string Model {get;set;}

            protected Position position;

            // private variable accessable.
            public string Make
            {
                get {return make;}
                set {make = value;}
            }

            //property for x
            public int x
            {
                get {return position.x;}
            }
            public Vehicles(string make, string model)
            {
                this.make = make;
                this.Model = model;
            }
            public void MoveForward()
            {
                position.x += 1;
            }


    }

    public class Car : Vehicles
    {
        int numberOfWheels;
        int currentGear;
        public Car(int numberOfWheels, string make, string model):base(make,model)
        {
            this.numberOfWheels = numberOfWheels;
            currentGear = 0;
        }
        public void Reverse()
        {
            position.x -= 1;
        }
    }


    public struct Position
    {
        public int x, y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Vehicles");
            Car car1 = new Car(4, "Ford", "B-MAX");

            Console.WriteLine($"{car1.Model} position: {car1.x}");
            for(int i =0; i < 10; i++)
            {
                car1.MoveForward();
                Console.WriteLine($"{car1.Model} position: {car1.x}");
            }
            
        }
    }
}
