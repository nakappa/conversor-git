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
            Console.Write("Escolha 1 (BINÁRIO), 2 (DECIMAL), 3 (HEXADECIMAL) ou 4 (SAIR): ");
            int contador = 0;
            while (contador == 0)
            {
                int escolha = int.Parse(Console.ReadLine());
                    if (escolha < 1 || escolha > 4)
                    {
                        Console.Write("FAVOR DIGITAR UM VALOR ENTRE 1 À 4!!! Qual a sua escolha [1 (BINÁRIO), 2(DECIMAL), 3(HEXADECIMAL) ou 4(SAIR)]? ");
                        contador = 0;
                    }

                    if (escolha == 1)
                    {
                        ConvertBin conBin = new ConvertBin();
                        conBin.convertBin();
                        contador = 0;
                        Console.Write("Escolha 1 (BINÁRIO), 2 (DECIMAL), 3 (HEXADECIMAL) ou 4 (SAIR): ");
                    }

                    if (escolha == 2)
                    {
                        ConvertDec conDec = new ConvertDec();
                        conDec.convertDec();
                        contador = 0;
                        Console.Write("Escolha 1 (BINÁRIO), 2 (DECIMAL), 3 (HEXADECIMAL) ou 4 (SAIR): ");
                    }

                    if (escolha == 3)
                    {
                        ConvertHex conHex = new ConvertHex();
                        conHex.convertHex();
                        contador = 0;
                        Console.Write("Escolha 1 (BINÁRIO), 2 (DECIMAL), 3 (HEXADECIMAL) ou 4 (SAIR): ");
                    }

                    if (escolha == 4)
                    {
                        contador = 1;
                        Console.WriteLine();
                        Console.WriteLine("ADEUS!!!");
                    }

            }

            Console.ReadLine();
        }
    }
}