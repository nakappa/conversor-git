namespace System //Conversor_BIN_DEC_HEX.Functions
{
    class ConvertDecBinHex
    {
        public void ConvertBinHex()
        {
            int contador = 0;
            Console.WriteLine();
            Console.Write("Digite um número decimal: ");
            ConversorBinario bin = new ConversorBinario { digito = Console.ReadLine() };
            ConversorHexadecimal hex = new ConversorHexadecimal();
            char[] s = bin.digito.ToCharArray();

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
                    bin.digito = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Número digitado foi: " + bin.digito);
                    s = bin.digito.ToCharArray();
                    contador = 0;
                }

                else
                {
                    Console.WriteLine();
                    Console.Write("Número digitado é: " + bin.digito);
                    contador = 1;
                }
            }

            Console.WriteLine();
            bin.Bina();
            Console.WriteLine();
            hex.digito = bin.digito;
            hex.Hexa();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}