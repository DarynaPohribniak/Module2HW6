﻿namespace Module2HW6
{
    public class PetrolEngineVehicle : InternalCombustionVehicle
    {
        public PetrolEngineVehicle(decimal price, double fuelConsumption)
            : base(price, fuelConsumption)
        {
        }

        public override decimal Price { get; set; }
        public override double FuelConsumption { get; set; }

        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("It is petrol engine vehicle.");
        }
    }
}
