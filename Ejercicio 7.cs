using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_de_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[10];
            int nums2 = 0, nums3;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduzca un numero: (" + (i + 1) + "/10)");
                nums1[i] = Convert.ToInt32(Console.ReadLine());
                nums2 = nums1[i];
            }
            nums3 = nums2 / 10;
            Console.WriteLine("La Media de estos numeros es: " + nums3);
            Console.WriteLine("Los numeros por arriba de la media son: ");
            for (int i = 0; i < 10; i++)
            {
                if (nums1[1] > nums3)
                {
                    Console.Write(nums1[i] + ",");
                }
            }
            Console.ReadKey();
        }
    }
}
