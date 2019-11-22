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
            //ConvertBin binar = new ConvertBin();
            //binar.convertBin();

            ConvertDec binar = new ConvertDec();
            binar.convertDec();

            Console.ReadLine();
        }
    }
}
