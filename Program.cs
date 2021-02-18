using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numero1,numero2;

            Console.WriteLine("Digite su Primer Numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite su Segundo Numero: ");
            numero2 = int.Parse(Console.ReadLine());
            
            if (numero1 > numero2 )
            {
                Console.WriteLine("El numero mayor es el primero ");
            }
            else if (numero2 > numero1 )
            {
                Console.WriteLine("El numero mayor es el segundo ");
            }
            else if (numero1 == numero2)
            {
                Console.WriteLine("Los numeros son iguales");
            }
            Console.ReadKey();

        }
    }
}
