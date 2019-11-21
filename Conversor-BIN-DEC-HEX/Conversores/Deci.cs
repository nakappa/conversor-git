using System;
using System.Collections.Generic;

namespace System //Conversor_BIN_DEC_HEX
{
    class Deci
    {
        public List<int> list = new List<int>();
        public List<string> list2 = new List<string>();
        public string digito;
        public string s;
        public int valor;
        public int aux;
        public int resto;

        public void bina()
        {
            valor = int.Parse(digito);
            Console.WriteLine();

            while (valor != 0)
            {
                int resultado = valor / 2;
                resto = valor % 2;
                aux = resultado;
                valor = aux;
                list.Insert(0, resto);
            }

            Console.Write("Número binário: ");

            foreach (int obj in list)
            {
                Console.Write(obj);
            }
        }

        public void hexa()
        {
            valor = int.Parse(digito);
            while (valor != 0)
            {
                int resultado = valor / 16;
                resto = valor % 16;
                aux = resultado;
                valor = aux;
                s = resto.ToString();
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
                list2.Insert(0, s);
            }

            Console.Write("Número hexadecimal: ");
            foreach (string obj in list2)
            {
                Console.Write(obj);
            }
        }
    }
}