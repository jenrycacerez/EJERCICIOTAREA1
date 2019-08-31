using System;

namespace ejercicio6
{
    class par_o_impar
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Digite un nuemro");
            num = int.Parse(Console.ReadLine());
            
            if(num % 2 == 0)
            {
                Console.WriteLine("el numero es par");

            }
            else
            {
                Console.WriteLine("el numero es impar");
            }
            Console.ReadKey();
        }
    }
}
