using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaDeLaSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite # de 1 al 7");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine(" Dia Lunes ");
                    break;
                case 2:
                    Console.WriteLine(" Dia martes");
                    break;

                case 3:
                    Console.WriteLine(" Dia Miercoles");
                    break;
                case 4:
                    Console.WriteLine(" Dia Jueves");
                    break;
                case 5:
                    Console.WriteLine(" Dia Viernes");
                    break;
                case 6:
                    Console.WriteLine(" Dia Sabado ");
                    break;
                case 7:
                    Console.WriteLine(" Dia Domingo");
                    break;
                default:
                    Console.WriteLine(" Error # no Valido");
                    break;
            }
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
       