using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System //Conversor_BIN_DEC_HEX.Conversores
{
    class Bina
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

                    default:
                        valor = 1;
                        break;
                }
                x[z] = valor * Math.Pow(2, y);

                giro++;
            }

            giro = 0;
            y = 0;

            for (int i = 0; i < n; i++)
            {
                y += x[i];
            }

            Console.WriteLine("Número decimal: " + y);
        }
    }
}