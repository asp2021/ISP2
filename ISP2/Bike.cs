using System;

namespace ISP2
{
    class Bike : IVehicle
    {
        public int GetNumberOfWheel()
        {
            return 2;
        }

        public void Move()
        {
            Console.WriteLine("me muevo en 2 ruedas");
        }
    }
}
