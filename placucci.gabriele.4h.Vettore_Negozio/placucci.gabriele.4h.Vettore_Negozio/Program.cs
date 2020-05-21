using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace placucci.gabriele._4h.Vettore_Negozio
{
    class Program
    {
        private static Stream Prezzi;

        static void Main(string[] args)
        {
        //in un array sono contenuti i prezzi di vendita di un determinato prodotto relativo agli N supermercati dove è presente.
        //Se in un negozio il prodotto non è presente il prezzo associato è 0€.

            int CodiceSM = 0;
            int minore=0;
            
            int[] SM = new int[]{  100, 10, 1000, 2000};     //(step 1) Il codice del supermercato corrisponde all'indice del vettore.    



            //Scrivi un programma che, dopo aver caricato i dati, permetta di:


            //a.stampare il prezzo minimo del prodotto ed in quale supermercato si è rilevato

            minore = SM[0];

            for (int i = 0; i < SM.Length-1; i=i+1)
            {           
                if(SM[i] < minore) 
                {
                    minore = SM[i];
                    CodiceSM = i;
                }
                
            }
           Console.WriteLine("il prezzo minimo è: " +  minore + " , ed è presente nel supermercato con codice " + CodiceSM  );


            //b.stampare la differenza di ciascun prezzo da uno specifico valore fornito in input

            int differenza = 0;
            int valore = 0;

            Console.WriteLine("Ora andremo a calcolare la differenza di ogni prodotto con un numero da te inserito...");
            valore=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("il tuo valore è: "+valore);
            Console.WriteLine(" ");


            //c.stampare in quali negozi il prezzo è inferiore rispetto a quello inserito in input


            for (int j=0; j<SM.Length; j++) 
            {
                differenza = SM[j] - valore;
                Console.WriteLine("La differenza con il prodotto "+ j +" è: "+ differenza );
                if (differenza < valore) 
                {
                    Console.WriteLine("nel negozio "+j+" la differenza è minore del valore inserito");
                    Console.WriteLine(" ");
                }
                else 
                {
                    Console.WriteLine("Differenza maggiore del valore da te inserito");
                    Console.WriteLine(" ");
                }
            }

           
           








            
            //(step 2) modifica il codice affinché sia possibile gestire il nome e l'indirizzo del negozio e conseguentemente stamparne nei punti a., b. e c. i relativi dati.
            //(step 3) caricare i dati da file.




            //Console.WriteLine(SM.Max());  // returns the largest value
            //Console.WriteLine(SM.Min());  // returns the smallest value
            //Console.WriteLine(SM.Sum());  // returns the sum of elements







            Console.ReadKey();
        }
    }
}
