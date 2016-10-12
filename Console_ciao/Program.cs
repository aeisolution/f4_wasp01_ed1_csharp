using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_ciao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I parametri passati sono n.{0} ", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            // Programma di benvenuto
            /* descrizione:
                Il programma deve richiedere all'utente il nome e cogome
                e rispondere con il seguente messaggio:
                 Benvenuto, nome cognome!

                (es. benvenuto, Andrea Maddalena!)
            */
            String nome = "";
            String cognome = "";

            int numProve = 0;

            while (nome == "")
            {
                if(numProve>=3)
                {
                    Console.WriteLine("Non hai capito nulla");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("Inserisci il tuo nome:");
                nome = Console.ReadLine();
                numProve++;
            }

            while (cognome == "")
            {
                Console.WriteLine("Inserisci il tuo cognome:");
                cognome = Console.ReadLine();
            }
            Console.WriteLine("Benvenuto, {0} {1}!", nome, cognome);





            Console.ReadKey();


        }
    }
}
