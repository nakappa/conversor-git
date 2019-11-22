using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System //Conversor_BIN_DEC_HEX.Functions
{
    class ConvertHex
    {
        public void convertHex()
        {
            int contador = 0;
            Console.WriteLine();
            Console.Write("Digite um número hexadecimal: ");
            Hexa hexad = new Hexa();
            hexad.digito = Console.ReadLine();
            int n = hexad.digito.Length;
            char[] s = new char[n];
            s = hexad.digito.ToCharArray();

            while (contador == 0)
            {
                foreach (char w in s)
                {
                    if (w != '0' && w != '1' && w != '2' && w != '3' && w != '4' && w != '5' && w != '6' && w != '7' && w != '8' && w != '9' && w != 'a' && w != 'b' && w != 'c' && w != 'd' && w != 'e' && w != 'f' && w != 'A' && w != 'B' && w != 'C' && w != 'D' && w != 'E' && w != 'F') contador = 1;
                }

                if (contador == 1)
                {
                    Console.WriteLine("FAVOR DIGITAR ALGARISMOS ENTRE 0 ATÉ 9 E OU A ATÉ F!!!");
                    Console.WriteLine();
                    Console.Write("Digite um número hexadecimal: ");
                    hexad.digito = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Número digitado é: " + hexad.digito);
                    n = hexad.digito.Length;
                    s = new char[n];
                    s = hexad.digito.ToCharArray();
                    contador = 0;
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Número digitado é: " + hexad.digito);
                    contador = 1;
                }
            }

            Console.WriteLine();
            hexad.bina();
            Console.WriteLine();
            hexad.deci();
            Console.WriteLine("Número decimal: " + hexad.y);
            Console.WriteLine();
        }
    }
}