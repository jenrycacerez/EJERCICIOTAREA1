using System;

namespace ejercicio7
{
    class dias

    {
        static void Main(string[] args)
        {
            byte dia;

            Console.WriteLine("Digite Numero Dia: ");
            dia = Convert.ToByte(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Lunes");
                    break;
                case 3:
                    Console.WriteLine("Martes");
                    break;
                case 4:
                    Console.WriteLine("Miercoles");
                    break;
                case 5:
                    Console.WriteLine("Jueves");
                    break;
                case 6:
                    Console.WriteLine("Viernes");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
           


            }
            Console.ReadKey();
        }
    }
}
