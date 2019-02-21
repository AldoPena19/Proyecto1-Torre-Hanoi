using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionTorreHanoi
{
    class Proyecto1
    {
        static void torresHanoi(int n, int o, int d, int aux)
        {
            if (n > 0)
            {
                torresHanoi(n-1, o, aux, d);
                Console.Write("\nSe Mueve anillo desde Torre " + o + " Hasta Torre " + d);
                torresHanoi(n-1, aux, d, o);
            }
        }
        static void Main(string[] args)
        {
            int n;

            Console.Write("J U E G O - T O R R E - D E - H A N O I");
            Console.Write("\n\nGRUPO NO.6");
            Console.Write("\n\nEl problema planteado consiste en crear una solucion, que nos permita resolver el juego de las torres de hanoi.");
            Console.Write("\n\nREGLAS:");
            Console.Write("\nSe debe mover los discos de Torre 1 Origen a la Torre 3 Nueva posicion considerando Posicion Auxiliar.");
            Console.Write("\nNunca se puede colocar un disco sobre uno pequeño.");
            Console.Write("Favor ingresar la cantidad de anillos: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("\n\nSOLUCION: \n");
            torresHanoi(n, 1, 3, 2);
            Console.ReadKey();
        }
    }
}



