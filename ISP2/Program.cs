using System;

namespace ISP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOLID" + '\n');
            Console.WriteLine("ISP - Interface Segregation Principle" + '\n');
            Console.WriteLine("No debemos tener intefaces muy grandes de tal forma que no obliguemos a los objetos que la implementan a implementar metodos que no necesiten" + '\n');

            Console.WriteLine("Bicicleta");
            Bike vehiculo = new Bike();
            vehiculo.Move();
            Console.WriteLine("Ruedas: " + vehiculo.GetNumberOfWheel().ToString());

            Console.WriteLine();

            Console.WriteLine("Automovil");
            Car car = new Car();
            car.Move();
            Console.WriteLine("Ruedas: " + car.GetNumberOfWheel().ToString());
            Console.WriteLine("Encendido: " + car.StartEngine().ToString());
            Console.WriteLine("Apagado: " + car.StopEngine().ToString());


        }
    }
}
