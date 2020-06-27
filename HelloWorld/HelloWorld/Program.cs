using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            DoJob();
        }

        static void DoJob()
        {
            var elTrabajo = new Trabajo();
            elTrabajo.RealiceConsultasNorthWind();
        }
    }
}
