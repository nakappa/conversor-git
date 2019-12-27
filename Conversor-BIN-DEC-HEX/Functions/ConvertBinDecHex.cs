namespace System //Conversor_BIN_DEC_HEX.Functions
{
    class ConvertBinDecHex
    {
        public void ConvertDecHex()
        {
            int contador = 0;
            Console.WriteLine();
            Console.Write("Digite um número binário: ");
            ConversorDecimal dec = new ConversorDecimal {digito = Console.ReadLine()};
            ConversorHexadecimal hex = new ConversorHexadecimal();
            char[] s = dec.digito.ToCharArray();

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
                    dec.digito = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Número digitado foi: " + dec.digito);
                    s = dec.digito.ToCharArray();
                    contador = 0;
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Número digitado foi: " + dec.digito);
                    contador = 1;
                }
            }

            Console.WriteLine();
            dec.DeciBin();
            hex.digito = dec.y.ToString();
            hex.Hexa();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

