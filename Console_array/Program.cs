using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // definizione e inizializzazione array di interi
            int[] ordini = new int[6] { 23, 12, 5, 7, 88, 2 };

            // Stampa del primo valore
            Console.WriteLine("posizione {0} = {1}", 0, ordini[0]);
            Console.WriteLine("posizione {0} = {1}", 1, ordini[1]);
            Console.WriteLine("posizione {0} = {1}", 2, ordini[2]);
            Console.WriteLine("posizione {0} = {1}", 3, ordini[3]);
            Console.WriteLine("posizione {0} = {1}", 4, ordini[4]);
            Console.WriteLine("posizione {0} = {1}", 5, ordini[5]);

            // Stampare a video l'elenco dei valori di ordini
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("posizione {0} = {1}", i, ordini[i]);

                Console.ReadKey();
            }


        }
    }
}
