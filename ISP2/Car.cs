using System;

namespace ISP2
{
    public class Car : IVehicle, IEngineVehicle
    {
        public int GetNumberOfWheel()
        {
            return 4;
        }

        public void Move()
        {
            Console.WriteLine("me muevo en 4 ruedas");
        }

        public int StartEngine()
        {
            return 1;
        }

        public int StopEngine()
        {
            return 0;
        }
    }
}
