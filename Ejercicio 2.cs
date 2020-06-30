 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int[] reales = new int[5];


            for (int i = 0; i < 5; i++)
            {
                reales[i] = int.Parse(Console.ReadLine());

            }

           
            Array.Reverse(reales);
            Console.Write("Array de manera opuesta: ");
            foreach (int i in reales)
            {
                Console.Write(i + " ");

            }
                Console.ReadKey();
          
        }
        

    }
}
