using System.Collections.Generic;

namespace System //Conversor_BIN_DEC_HEX.Conversores
{
    class ConversorBinario
    {
        public List<int> list = new List<int>();
        public string digito;

        public void Bina()
        {
            int valor = int.Parse(digito);

            while (valor != 0)
            {
                int resultado = valor / 2;
                int resto = valor % 2;
                int aux = resultado;
                valor = aux;
                list.Insert(0, resto);
            }

            Console.Write("Convertido em binário é: ");

            foreach (int obj in list)
            {
                Console.Write(obj);
            }
        }
    }
}