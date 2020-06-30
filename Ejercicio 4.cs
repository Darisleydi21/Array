using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            while (i > 0 && i <= 12)
            {
                int[] meses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                Console.WriteLine("Diga el numero del mes que quiere consultar, por ejemplo: 1=enero, 2=febrero: ");
                i = Convert.ToInt32(Console.ReadLine());
       
                
                Console.WriteLine(" El mes que ha seleccionado tiene {0} dias", meses[i - 1]);



                Console.WriteLine("    ");



            }

            Console.ReadKey();





        }
    }
}
