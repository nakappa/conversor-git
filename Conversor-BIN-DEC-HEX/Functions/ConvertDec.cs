using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System //Conversor_BIN_DEC_HEX.Functions
{
    class ConvertDec
    {
        public void convertDec()
        {
            int contador = 0;
            Console.WriteLine();
            Console.Write("Digite um número decimal: ");
            Deci decim = new Deci();
            decim.digito = Console.ReadLine();
            int n = decim.digito.Length;
            char[] s = new char[n];
            s = decim.digito.ToCharArray();

            while (contador == 0)
            {
                foreach (char w in s)
                {
                    if (w != '0' && w != '1' && w != '2' && w != '3' && w != '4' && w != '5' && w != '6' && w != '7' && w != '8' && w != '9') contador = 1;
                }

                if (contador == 1)
                {
                    Console.WriteLine("FAVOR DIGITAR ALGARISMOS ENTRE 0 À 9!!!");
                    Console.WriteLine();
                    Console.Write("Digite um número decimal: ");
                    decim.digito = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Número digitado é: " + decim.digito);
                    n = decim.digito.Length;
                    s = new char[n];
                    s = decim.digito.ToCharArray();
                    contador = 0;
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Número digitado é: " + decim.digito);
                    contador = 1;
                }
            }

            decim.bina();
            Console.WriteLine();
            decim.hexa();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}