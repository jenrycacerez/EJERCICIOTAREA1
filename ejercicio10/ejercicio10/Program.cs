using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, pot, res;

            Console.WriteLine("Digite el numero que desea elevar: ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a la potencia que desea elevar: ");
            pot = Convert.ToDouble(Console.ReadLine());

            res = Math.Pow(num, pot);

            Console.WriteLine("El resultado es: " + res);
            Console.ReadKey();



        }
    }
}
