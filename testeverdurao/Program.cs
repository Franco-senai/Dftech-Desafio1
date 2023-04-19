using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeverdurao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meudesenho();
            
           
            Console.ReadLine();
           
            
        }

        public static void Meudesenho()
        {
          
            int i = 0;
            string espaco = "";



            Console.WriteLine("_______________________________");

            while (i < 4)

            {
                Console.WriteLine(espaco);
                i++;
            }

            Console.WriteLine("_______________________________");

        }
    }

        

 }


