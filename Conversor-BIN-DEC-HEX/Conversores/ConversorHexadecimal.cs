using System.Collections.Generic;

namespace System //Conversor_BIN_DEC_HEX.Conversores
{
    class ConversorHexadecimal
    {
        public List<string> list = new List<string>();
        public string digito;

        public void Hexa()
        {
            int valor = int.Parse(digito);
            while (valor != 0)
            {
                int resultado = valor / 16;
                int resto = valor % 16;
                int aux = resultado;
                valor = aux;
                string s = resto.ToString();

                switch (s)
                {
                    case "0":
                        s = "0";
                        break;

                    case "1":
                        s = "1";
                        break;

                    case "2":
                        s = "2";
                        break;

                    case "3":
                        s = "3";
                        break;

                    case "4":
                        s = "4";
                        break;

                    case "5":
                        s = "5";
                        break;

                    case "6":
                        s = "6";
                        break;

                    case "7":
                        s = "7";
                        break;

                    case "8":
                        s = "8";
                        break;

                    case "9":
                        s = "9";
                        break;

                    case "10":
                        s = "A";
                        break;

                    case "11":
                        s = "B";
                        break;

                    case "12":
                        s = "C";
                        break;

                    case "13":
                        s = "D";
                        break;

                    case "14":
                        s = "E";
                        break;

                    default:
                        s = "F";
                        break;

                }
                list.Insert(0, s);
            }

            Console.Write("Convertido em hexadecimal é: ");
            foreach (string obj in list)
            {
                Console.Write(obj);
            }
        }
    }
}