namespace System //Conversor_BIN_DEC_HEX.Functions
{
    class Decisao
    {
        public int escolha;

        public void Decide()
        {
            Console.WriteLine("CONVERSOR NUMÉRICO!!!");
            Console.Write("Escolha 1 (BINÁRIO / DECIMAL & HEXADECIMAL), 2 (DECIMAL / BINÁRIO & HEXADECIMAL), 3 (HEXADECIMAL / BINÁRIO & DECIMAL) ou 4 (SAIR): ");
            int contador = 0;
            while (contador == 0)
            {
                try
                {
                    escolha = int.Parse(Console.ReadLine());
                    if (escolha < 1 || escolha > 4)
                    {
                        Console.Write("FAVOR DIGITAR UM VALOR ENTRE 1 À 4!!! Qual a sua escolha [1 (BINÁRIO / DECIMAL & HEXADECIMAL), 2 (DECIMAL / BINÁRIO & HEXADECIMAL), 3 (HEXADECIMAL / DECIMAL & BINÁRIO) ou 4 (SAIR)]? ");
                    }

                    if (escolha == 1)
                    {
                        ConvertBinDecHex conDecHex = new ConvertBinDecHex();
                        conDecHex.ConvertDecHex();
                        Console.Write("Escolha 1 (BINÁRIO / DECIMAL & HEXADECIMAL), 2 (DECIMAL / BINÁRIO & HEXADECIMAL), 3 (HEXADECIMAL / BINÁRIO & DECIMAL) ou 4 (SAIR): ");
                    }

                    if (escolha == 2)
                    {
                        ConvertDecBinHex conBinHex = new ConvertDecBinHex();
                        conBinHex.ConvertBinHex();
                        Console.Write("Escolha 1 (BINÁRIO / DECIMAL & HEXADECIMAL), 2 (DECIMAL / BINÁRIO & HEXADECIMAL), 3 (HEXADECIMAL / BINÁRIO & DECIMAL) ou 4 (SAIR): ");
                    }

                    if (escolha == 3)
                    {
                        ConvertHexDecBin conBinDec = new ConvertHexDecBin();
                        conBinDec.ConvertBinDec();
                        Console.Write("Escolha 1 (BINÁRIO / DECIMAL & HEXADECIMAL), 2 (DECIMAL / BINÁRIO & HEXADECIMAL), 3 (HEXADECIMAL / BINÁRIO & DECIMAL) ou 4 (SAIR): ");
                    }

                    if (escolha == 4)
                    {
                        contador = 1;
                        Console.WriteLine();
                        Console.WriteLine("ADEUS!!!");
                        Console.ReadLine();
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    Console.Write("FAVOR DIGITAR UM VALOR ENTRE 1 À 4!!! Qual a sua escolha [1 (BINÁRIO / DECIMAL & HEXADECIMAL), 2 (DECIMAL / BINÁRIO & HEXADECIMAL), 3 (HEXADECIMAL / BINÁRIO & DECIMAL) ou 4 (SAIR)? ");
                    contador = 0;
                }

            }
        }
    }
}