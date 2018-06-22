using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public delegate void DelegadoEstado(object sender, EventArgs e);

    public class Paquete: IMostrar<Paquete>
    {
        private string _direccionEntrega;
        private EEstado _estado;
        private string _trackingID;
        public Exception HayExcepcion = null;

        #region Propiedades

        public string DireccionEntrega
        {
            get { return this._direccionEntrega; }
            set { this._direccionEntrega = value; }
        }

        public EEstado Estado
        {
            get { return this._estado; }
            set { this._estado = value; }
        }

        public string TrackingID
        {
            get { return this._trackingID; }
            set { this._trackingID = value; }
        }

        #endregion

        public event DelegadoEstado InformaEstado;

        public Paquete(string dirEntrega, string tracking)
        {
            this.TrackingID = tracking;
            this.DireccionEntrega = dirEntrega;
            this.Estado = EEstado.Ingresado;//inicializo estado
        }

        public void MockCicloDeVida()
        {
            Thread.Sleep(10000);
            this.Estado = EEstado.EnViaje;
            //INFORMAR ESTADO MEDIANTE EVENTO
            EventArgs a = new EventArgs();
            this.InformaEstado.Invoke(this, a);
            Thread.Sleep(10000);
            this.Estado = EEstado.Entregado;
            //INFORMAR ESTADO MEDIANTE EVENTO
            this.InformaEstado.Invoke(this, a);

            bool resp = PaqueteDAO.Insertar(this);
            if (resp == false)
            {
                Exception ex = new Exception("Ocurrio un error al intentar insertar en la bd.");
                throw ex;
            }
        }

        public override string ToString()
        {
            return ((IMostrar<Paquete>)this).MostrarDatos(this);
            //return "Tracking ID: " + this.TrackingID + "\nEstado: " + this.Estado + "\nDireccion: " + this.DireccionEntrega;
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            bool retValue = false;
            if ((object)p1 != null && (object)p2 != null)
            {
                if (p1.TrackingID == p2.TrackingID)
                {
                    retValue = true;
                }
            }
            return retValue;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }
        
        string IMostrar<Paquete>.MostrarDatos(IMostrar<Paquete> elemento)
        {
            string ret = "";
            if (elemento != null)
            {
                ret = string.Format("{0} para {1}", ((Paquete)elemento).TrackingID, ((Paquete)elemento).DireccionEntrega);
            }
            return ret;
        }
    }
}
