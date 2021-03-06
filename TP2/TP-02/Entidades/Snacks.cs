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
    public class Snacks: Producto
    {
        public Snacks(EMarca marca, string codigo, ConsoleColor color)
            : base(codigo, marca, color)
        {
        }
        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("CALORIAS : "+ this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();

            //string retValue = "SNACKS\n";
            //retValue += base.Mostrar();
            //retValue += "CALORIAS :" + this.CantidadCalorias + "\n\n";
            //retValue += "---------------------";
            //return retValue;
        }
}
}
