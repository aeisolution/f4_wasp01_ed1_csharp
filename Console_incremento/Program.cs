using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_incremento
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7, b;
            float f;

            /*
            Console.WriteLine("x.CompareTo(2)= {0}",x.CompareTo(2));
            Console.WriteLine("x.CompareTo(5)= {0}", x.CompareTo(7));
            Console.WriteLine("x.CompareTo(8)= {0}", x.CompareTo(8));
            */

            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine("{1}.CompareTo({0})= {2}", i, x, x.CompareTo(i), );
            }

            

            Console.ReadKey();
            return;

            decimal prezzo;

            DateTime dataOdierna = DateTime.Now;



            // Caso 1
            Console.WriteLine("b = " + x);
            x = x + 1;
            Console.WriteLine("b = {0}", x);
            Console.WriteLine("b = {0}",++x);
            Console.WriteLine("b = {0}", x++);


            // Caso 2
            x = 7;
            b = x;
            Console.WriteLine("b = " + b);
            x = x + 1;
            b = x;
            Console.WriteLine("b = {0}", b);
            b = ++x;
            Console.WriteLine("b = {0}", b);
            b = x++;
            Console.WriteLine("b = {0}", b);


            // Riga inserita per blocco finestra
            Console.ReadKey();
        }
    }
}
