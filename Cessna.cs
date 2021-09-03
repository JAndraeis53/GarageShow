using System;
namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna zips by you. Zzzzooooommm!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The Cessna rolls down the runway for a mile then stops.");
            Console.WriteLine(" ");
        
        }
    }
}
