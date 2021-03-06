﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * MORENO SAMANTHA 2A
 * 
 */

namespace Entidades_2017
{
    public class Dulce : Producto
    {
        public Dulce(EMarca marca, string codigo, ConsoleColor color):base(codigo, marca, color)
        {
        }
        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("CALORIAS : "+ this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
            //string retValue = "DULCE\n";
            //retValue += base.Mostrar();
            //retValue += "CALORIAS :" + this.CantidadCalorias + "\n\n";
            //retValue += "---------------------";
            //return retValue;
        }
    }
}
