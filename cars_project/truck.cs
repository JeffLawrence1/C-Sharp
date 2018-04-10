using System;

namespace cars_project{
    public class Truck: Car{

         public Truck(int wheels, 
                    string make,
                    string model,
                    int year,
                    double mileage,
                    string interior) : base(wheels, make, model, year, mileage, interior){

         }
        public Truck( 
            string make,
            string model,
            int year,
            double mileage,
            string interior) : base(4, make, model, year, mileage, interior){
            
            }
        public string carWashCost(double washcost){
            return "Trucks cost $12.00 to wash at the Brown Bear";
        }
    }
}