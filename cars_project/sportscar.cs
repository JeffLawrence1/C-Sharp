using System;

namespace cars_project{
    
    public class SportsCar: Car{

         public SportsCar(int wheels, 
                    string make,
                    string model,
                    int year,
                    double mileage,
                    string interior) : base(wheels, make, model, year, mileage, interior){

         }
        public SportsCar( 
            string make,
            string model,
            int year,
            double mileage,
            string interior) : base(4, make, model, year, mileage, interior){
            
            }
        public string carWashCost(double washcost){
            return "Sportscars cost $13.00 to wash at the Brown Bear";
        }
    }
}