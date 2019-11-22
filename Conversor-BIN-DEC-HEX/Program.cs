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

            //ConvertDec decim = new ConvertDec();
            //decim.convertDec();

            ConvertHex hexad = new ConvertHex();
            hexad.convertHex();

            Console.ReadLine();
        }
    }
}
