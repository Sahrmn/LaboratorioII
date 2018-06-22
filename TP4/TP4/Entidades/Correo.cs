using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo: IMostrar<List<Paquete>>
    {
        private List<Thread> _mockPaquetes;
        private List<Paquete> _paquetes;

        public List<Paquete> Paquetes
        {
            get { return this._paquetes; }
            set
            {
                if (value != null)
                {
                    this._paquetes = value;
                }
            }
        }

        public Correo()
        {
            this._paquetes = new List<Paquete>();
            //inicializar mockpaquetes
            this._mockPaquetes = new List<Thread>();
        }

        public void FinEntregas()
        {
            for (int i = 0; i < _mockPaquetes.Count; i++)
            {
                _mockPaquetes[i].Abort();
                _mockPaquetes.RemoveAt(i);
            }
        }

        string IMostrar<List<Paquete>>.MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            string ret = "";
            foreach (Paquete item in ((Correo)elemento).Paquetes)
            {
                ret += string.Format("{0} para {1} ({2})\n", item.TrackingID, item.DireccionEntrega, item.Estado.ToString());
            }
            
            return ret;
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            bool flag = false;
            if (p != null)
            {
                foreach (Paquete item in c.Paquetes)
                {
                    if (item == p)
                    {
                        flag = true;
                        TrackingIdRepetidoException e = new TrackingIdRepetidoException("El tracking ID " + p.TrackingID + " ya figura en la lista de envios.");
                        throw e;
                        //break;
                    }
                }
                if (flag == false)
                {
                    
                    c._paquetes.Add(p);
                    try
                    {
                        Thread hiloPaquete = new Thread(p.MockCicloDeVida);
                        c._mockPaquetes.Add(hiloPaquete);
                        hiloPaquete.Start();
                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return c;
        }

    }
}
