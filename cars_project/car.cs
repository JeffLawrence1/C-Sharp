using System;

namespace cars_project{
    public class Car{
        public int Wheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set;}
        private string interior;

        public Car(int wheels, string make, string model, int year, double mileage, string interior){
            Wheels = wheels;
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
            this.interior = interior;
        }
        public double drive(double mileage){
           this.Mileage += mileage;
           return Mileage;
        }
        public string carWashCost(double washcost){
            return "You paid $10.00 at the Brown Bear to wash your own car";
        }
    }
}