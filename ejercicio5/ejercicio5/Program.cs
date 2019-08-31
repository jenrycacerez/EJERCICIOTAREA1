using System;

namespace ejercicio5
{
    class convertidor 
    {
        static void Main(string[] args)
        {
            double dolar,euros,rdolar,reuros;
            Console.WriteLine("Digite cantidad en dolares");
            dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite cantidad en euro");
            euros = double.Parse(Console.ReadLine());
            rdolar = euros * 0.91;
            reuros = dolar * 1.10;
            Console.WriteLine("el cambio de dolares a euro es = {0}", reuros);
            Console.WriteLine("el cambio de euros a dolar es = {0}", rdolar);
            Console.ReadKey();
        }
    }
}

