using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double base1,perimetro;
            Console.WriteLine("Digite Base");
            base1 = double.Parse(Console.ReadLine());
            perimetro = base1 * 3;
            Console.WriteLine("Perimetro = {0}", perimetro);
            Console.ReadKey();
        }
    }
}
