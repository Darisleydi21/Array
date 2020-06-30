using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Dias = { 0, 31, 30, 28 };

            int[] Meses = new int[13];
            Meses[1] = Dias[1];
            Meses[2] = Dias[3];
            Meses[3] = Dias[1];
            Meses[4] = Dias[2];
            Meses[5] = Dias[1];
            Meses[6] = Dias[2];
            Meses[7] = Dias[1];
            Meses[8] = Dias[1];
            Meses[9] = Dias[2];
            Meses[10] = Dias[1];
            Meses[11] = Dias[2];
            Meses[12] = Dias[1];


            string[] meses = { "Index0", "Enero", "Febrero", "Marzo", "Abril",
                "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Obtubre", "Noviembre", "Diciembre" };


            var Año = DateTime.Now.Year;
            var Inicio = new DateTime(Año, 1, 1);

            Console.Write("Introduce un Mes: ");
            int Mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce un Dia: ");
            int DU = Convert.ToInt32(Console.ReadLine());


            var Fecha = new DateTime(Año, Mes, DU);
            var DE = Fecha - Inicio;


            Console.WriteLine("Falta {0} dias para que se acabe el año", 365 - DE.Days);

            Console.ReadKey();

        }
    }
}
