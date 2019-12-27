namespace System //Conversor_BIN_DEC_HEX.Functions
{
    class ConvertHexDecBin
    {
        public void ConvertBinDec()
        {
            int contador = 0;
            Console.WriteLine();
            Console.Write("Digite um número hexadecimal: ");
            ConversorDecimal dec = new ConversorDecimal { digito = Console.ReadLine() };
            ConversorBinario bin = new ConversorBinario();
            char[] s = dec.digito.ToCharArray();

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
                    dec.digito = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Número digitado é: " + dec.digito.ToUpper());
                    s = dec.digito.ToCharArray();
                    contador = 0;
                }

                else
                {
                    Console.WriteLine();
                    Console.Write("Número digitado é: " + dec.digito.ToUpper());
                    contador = 1;
                }
            }

            Console.WriteLine();
            dec.DeciHex();
            Console.WriteLine();
            bin.digito = dec.y.ToString();
            bin.Bina();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}