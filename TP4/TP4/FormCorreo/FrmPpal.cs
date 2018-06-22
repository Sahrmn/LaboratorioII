using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormCorreo
{
    public partial class FrmPpal : Form
    {
        private Correo _correo;

        public FrmPpal()
        {
            InitializeComponent();
            _correo = new Correo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Paquete unPaquete = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);
                unPaquete.InformaEstado += new DelegadoEstado(this.paq_InformaEstado);//asocio evento con metodo 
            
                this._correo += unPaquete;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ActualizarEstados();
        }

        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                DelegadoEstado d = new DelegadoEstado(paq_InformaEstado); 
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                ActualizarEstados();
            }
        }

        private void ActualizarEstados()
        {
            listBoxEstadoIngresado.Items.Clear();
            listBoxEstadoEnViaje.Items.Clear();
            listBoxEstadoEntregado.Items.Clear();
            foreach (Paquete item in this._correo.Paquetes)
            {
                switch (item.Estado)
                {
                    case EEstado.Ingresado:
                        listBoxEstadoIngresado.Items.Add(item);
                        break;
                    case EEstado.EnViaje:
                        listBoxEstadoEnViaje.Items.Add(item);
                        break;
                    case EEstado.Entregado:
                        listBoxEstadoEntregado.Items.Add(item);
                        break;
                    default:
                        break;
                }
            }
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._correo.FinEntregas();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            richTxtMostrar.Text = "";
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)_correo);
        }

        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            richTxtMostrar.Text = "";
            if (elemento != null)
            {
                richTxtMostrar.Text = (elemento.MostrarDatos(elemento)).ToString();

                try
                {
                    string texto = richTxtMostrar.Text;
                    texto.Guardar("salida.txt");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)listBoxEstadoEntregado.SelectedItem);
        }
    }
}
