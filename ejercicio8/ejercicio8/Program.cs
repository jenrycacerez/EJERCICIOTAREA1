using System;

namespace ejercicio8
{
    class area_perimetro
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige una opcion\n" +
                "\n1.-Desea calcular Area" +
                "\n2.-Desea calcular el perimetro" +
                "\n3.-Salir\n");
            string s1 = null;
            s1 = Console.ReadLine();
            double base1, perimetro,num,area,h;
            switch (s1)
            {
                case "1":
                    Console.WriteLine("Digite Base");
                    base1 = double.Parse(Console.ReadLine());
                    
                    Console.WriteLine("altura");
                    h = double.Parse(Console.ReadLine());
                    area = base1 * h/2;
                    Console.WriteLine("el area es  = {0}", area);

                    break;
                case "2":
                    Console.WriteLine("Digite Base:");
                    base1 = double.Parse(Console.ReadLine());
                    perimetro = base1 * 3;
                    Console.WriteLine("Perimetro = {0}", perimetro);
                    Console.ReadKey();

                    break;
                case "3":
                    Console.WriteLine("Opcion Salir:");

                    break;
            }
            Console.ReadKey();
        }
    }
}
