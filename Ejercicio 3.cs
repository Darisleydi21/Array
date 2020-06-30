using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana
{
    class Program
    {
        static void Main(string[] args)
        {
            byte Días;
            Console.WriteLine("Introduce un Dia: ");
            Días = Convert.ToByte(Console.ReadLine());

            switch (Días)
            {
                case 1: Console.WriteLine("Seleccionaste el Lunes");break;
                case 2: Console.WriteLine("Seleccionaste el Martes"); break;
                case 3: Console.WriteLine("Seleccionaste el Miercoles"); break;
                case 4: Console.WriteLine("Seleccionaste el Jueves"); break;
                case 5: Console.WriteLine("Seleccionaste el Viernes"); break;
                case 6: Console.WriteLine("Seleccionaste el Sabado"); break;
                case 7: Console.WriteLine("Seleccionaste el Domingo"); break;
                default: Console.WriteLine("Esto no es un Día");break;
            }
            Console.ReadKey();
        }
    }
}
