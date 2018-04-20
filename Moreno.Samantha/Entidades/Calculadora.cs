using System;

namespace Entidades
{
    public class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            string retValue = "+";
            if (string.Compare(operador,"+") == 0 || string.Compare(operador, "-") == 0 || string.Compare(operador, "*") == 0 || string.Compare(operador, "/") == 0)
            {
                retValue = operador;
            }
            return retValue;
        }

        public double Operar(Numero num1, Numero num2, string operador)
        {
            operador = Calculadora.ValidarOperador(operador);
            double retValue = 0;

            switch (operador)
            {
                case "+":
                    retValue = num1 + num2;
                    break;
                case "-":
                    retValue = num1 - num2;
                    break;
                case "*":
                    retValue = num1 * num2;
                    break;
                case "/":
                    retValue = num1 / num2;
                    break;
                default:
                    break;
            }
            return retValue;
        }
    }
}
