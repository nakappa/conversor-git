using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System //Conversor_BIN_DEC_HEX.Functions
{
    class ConvertBin
    {
        public void convertBin()
        {
            int contador = 0;
            Console.WriteLine();
            Console.Write("Digite um número binário: ");
            Bina binar = new Bina();
            binar.digito = Console.ReadLine();
            int n = binar.digito.Length;
            char[] s = new char[n];
            s = binar.digito.ToCharArray();

            while (contador == 0)
            {
                foreach (char w in s)
                {
                    if (w != '0' && w != '1') contador = 1;
                }

                if (contador == 1)
                {
                    Console.WriteLine("FAVOR DIGITAR ALGARISMOS ENTRE 0 OU 1!!!");
                    Console.WriteLine();
                    Console.Write("Digite um número binário: ");
                    binar.digito = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Número digitado é: " + binar.digito);
                    n = binar.digito.Length;
                    s = new char[n];
                    s = binar.digito.ToCharArray();
                    contador = 0;
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Número digitado é: " + binar.digito);
                    contador = 1;
                }
            }

            Console.WriteLine();
            binar.deci();
            Console.WriteLine("Número decimal: " + binar.y);
            binar.hexa();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}