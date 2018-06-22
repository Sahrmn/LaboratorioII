using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// metodo de extension
namespace Entidades
{
    public static class GuardaString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            bool retValue = false;
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path += "\\";
                path += archivo; 
                if (File.Exists(path))
                {
                    StreamWriter escribe = new StreamWriter(path,true);
                    escribe.WriteLine(texto);
                    escribe.Close();
                }
                else
                {
                    StreamWriter escribe = new StreamWriter(path);
                    escribe.WriteLine(texto);
                    escribe.Close();
                }
                retValue = true;
            }
            catch(Exception e)
            {
                retValue = false;
                throw e;
            }
            return retValue;
        }
    }
}
