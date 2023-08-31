using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Proyecto_sistema_facturacion
{
    public partial class frmEditarFacturas : MaterialForm
    {
        public frmEditarFacturas()
        {
            InitializeComponent();
        }
        public int idFactura { get; set; }

        private void frmEditarFacturas_Load(object sender, EventArgs e)
        {
            if (idFactura == 0)
            {
                lblTitulo.Text = "Ingeso Nueva factura";
            }
            else
            {
                lblTitulo.Text = "Modificar CLiente";
                lbNumeroFactura.Text = idFactura.ToString();
                cbCliente.Text = "Nombre 1 Apellido";
                cbEmpleado.Text = "Nombre 1 Apellido";
                txtDescuento.Text = "20";
                txtTotalIva.Text = "19";
                txtTotalFactura.Text = "50";
                cbEstadoFactura.Text = "Estado";
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Actualizados");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
