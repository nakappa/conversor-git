using System;
using System.Collections.Generic;

namespace System //Conversor_BIN_DEC_HEX.Conversores
{
    class Hexa
    {
        public List<int> list = new List<int>();
        public string digito;
        public int valor = 0;
        public int cont = 0;
        public double y;
        public int giro = 0;

        public void deci()
        {
            int n = digito.Length;
            char[] s = new char[n];
            s = digito.ToCharArray();
            double[] x = new double[n];

            foreach (char w in s)
            {
                int z = giro;
                y = n - giro - 1;

                switch (s[z])
                {
                    case '0':
                        valor = 0;
                        break;

                    case '1':
                        valor = 1;
                        break;

                    case '2':
                        valor = 2;
                        break;

                    case '3':
                        valor = 3;
                        break;

                    case '4':
                        valor = 4;
                        break;

                    case '5':
                        valor = 5;
                        break;

                    case '6':
                        valor = 6;
                        break;

                    case '7':
                        valor = 7;
                        break;

                    case '8':
                        valor = 8;
                        break;

                    case '9':
                        valor = 9;
                        break;

                    case 'a':
                        valor = 10;
                        break;

                    case 'A':
                        valor = 10;
                        break;

                    case 'b':
                        valor = 11;
                        break;

                    case 'B':
                        valor = 11;
                        break;

                    case 'c':
                        valor = 12;
                        break;

                    case 'C':
                        valor = 12;
                        break;

                    case 'd':
                        valor = 13;
                        break;

                    case 'D':
                        valor = 13;
                        break;

                    case 'e':
                        valor = 14;
                        break;

                    case 'E':
                        valor = 14;
                        break;

                    default:
                        valor = 15;
                        break;
                }
                x[z] = valor * Math.Pow(16, y);

                giro++;
            }

            giro = 0;
            y = 0;

            for (int i = 0; i < n; i++)
            {
                y += x[i];
            }
        }

        public void bina()
        {
            deci();
            Deci bina = new Deci();
            bina.digito = y.ToString();
            bina.bina();

        }

    }
}