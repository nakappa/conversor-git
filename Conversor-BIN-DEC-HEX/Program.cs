using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_BIN_DEC_HEX
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bina binar = new Bina();
            binar.digito = Console.ReadLine();
            binar.deci();
            Console.WriteLine("Número decimal: " + binar.y);
            binar.hexa();*/

            /*Deci decim = new Deci();
            decim.digito = Console.ReadLine();
            decim.bina();
            Console.WriteLine();
            decim.hexa();*/

            Hexa hexad = new Hexa();
            hexad.digito = Console.ReadLine();
            hexad.bina();
            Console.WriteLine();
            hexad.deci();
            Console.WriteLine("Número decimal: " + hexad.y);

            Console.ReadLine();
        }
    }
}
