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
            Bina binar = new Bina();
            binar.digito = Console.ReadLine();
            binar.deci();
            Console.WriteLine("Número decimal: " + binar.y);
            binar.hexa();

            Console.ReadLine();
        }
    }
}
