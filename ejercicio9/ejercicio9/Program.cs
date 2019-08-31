using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,i;
            Console.WriteLine("Digite El Valor de Numero");
            num = Convert.ToInt32(Console.ReadLine());
            for(i=0;i<=10;i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, (num * i));

            }
            Console.ReadKey();
        }
    }
}
