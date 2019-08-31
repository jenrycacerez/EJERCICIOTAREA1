using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, num, menor = 0,mayor = 0;
            Console.Write("Digite numero de Edades que quieres Consurtal");
            edad = int.Parse(Console.ReadLine());
            for(int i = 0; i < edad; i++)
            {
                Console.WriteLine("dijite edad ");
                num = int.Parse(Console.ReadLine());

                if(i == 0)
                {
                    mayor = num;
                    menor = num;
                }
                else if(i != 0)
                {
                    if(num < menor)
                    {
                        menor = num;
                    }
                    if(num > mayor)
                    {
                        mayor = num;
                    }
                }
            }
            Console.WriteLine("la edad menor es " + menor);
            Console.ReadKey();
        }
    }
}
