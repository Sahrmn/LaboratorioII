using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Numero
    {
        private double _numero;

        private string SetNumero
        {
            set { this._numero = ValidarNumero(value); }
        }

        public Numero() : this("0") { }

        public Numero(double num) : this(num.ToString()) { }

        public Numero(string srtNum)
        {
            this.SetNumero = srtNum;
        }

        private double ValidarNumero(string strNumero)
        {
            double retValue = 0;
            double temp = 0;
            bool tryParsear = double.TryParse(strNumero, out temp);
            if (tryParsear)
            {
                retValue = temp;
            }
            return retValue;
        }

        /// <summary>
        /// Convierte un número binario a decimal, en caso de ser posible. Caso contrario retornará "Valor inválido"
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public static string BinarioDecimal(string binario)
        {
            double numDecimal = 0;
            string retValue = "";
            bool flag = true;
            var cadenaIngresada = binario.ToCharArray(0, binario.Length);
            int indice = binario.Length - 1;

            foreach (char item in cadenaIngresada)
            {
                if (item != '0' && item != '1')
                {
                    retValue = "Valor invalido";
                    flag = false;
                    break;
                }
                else
                {
                    if (item == '1')
                    {
                        numDecimal += Math.Pow(2, indice);
                    }
                    indice--;
                }
            }
            if (flag == true)
            {
                retValue = numDecimal.ToString();
            }
            return retValue;
        }

        public static string DecimalBinario(double num)
        {
            string numBinario = "";
            int indice = 0;
            double sumatoria = 0;
            while (Math.Pow(2, indice) < num && Math.Pow(2, indice + 1) < num)
            {
                indice++;
            }
            numBinario += "1";
            sumatoria += Math.Pow(2, indice);
            for (int i = indice - 1; i >= 0; i--)
            {
                if ((sumatoria + Math.Pow(2, i)) <= num)
                {
                    numBinario += "1";
                    sumatoria += Math.Pow(2, i);
                }
                else
                    numBinario += "0";
            }
            return numBinario;
        }

        public string DecimalBinario(string num)
        {
            double conver = double.Parse(num);
            string retValue = DecimalBinario(conver);
            return retValue;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            double retValue = n1._numero + n2._numero;
            return retValue;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            double retValue = n1._numero - n2._numero;
            return retValue;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            double retValue = n1._numero * n2._numero;
            return retValue;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double retValue = 0;
            if (n2._numero != 0)
            {
                retValue = n1._numero / n2._numero;
            }
            return retValue;
        }
    }
}
