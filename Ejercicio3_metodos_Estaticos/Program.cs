using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_metodos_Estaticos
{
    internal class Program

    {
      static  int x = 12;
       static int y = 5;
        static void Main(string[] args)
        {
           

            Console.WriteLine("\nBase x: " + x + "\nAltura y: " +y);

            resultado(x, y);

            Console.ReadKey();
        }

        static int areaCuadrado (int bas, int altura)
        {

            return bas * altura;
;       
        }
        static void resultado(int bas, int altura)
        {
            Console.WriteLine("Area del Cuadrado: " +areaCuadrado(bas, altura));
        }

    
    }
    
}
