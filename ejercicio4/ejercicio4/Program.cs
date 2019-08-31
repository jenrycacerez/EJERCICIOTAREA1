using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double grados, radianes;
            Console.WriteLine("Digite Grados");
            grados = double.Parse(Console.ReadLine());
            radianes = grados * 180/3.1416;
            Console.WriteLine("Los Radianes son = {0}", radianes);
            Console.ReadKey();
        }
    }
}
