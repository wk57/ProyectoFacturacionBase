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
    public partial class frmEditarProducto : MaterialForm
    {
        public frmEditarProducto()
        {
            InitializeComponent();
        }
        public int IdProducto { get; set; }

        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
           if (IdProducto == 0)
            {
                lblTituloProducto.Text = "Ingreso de nuevo producto";
            }
            else
            {
                lblTituloProducto.Text = "Modificar producto";
                txtIdProducto.Text = IdProducto.ToString();
                txtNombreProducto.Text = "Nombre producto 1 ";
                txtCodigoReferencia.Text = "1a233";
                txtPrecioCompra.Text = "1000";
                txtPrecioVenta.Text = "2000";
                txtCantidadStock.Text = "5";
                txtRutaImagen.Text = "url";
                txtDetallesProducto.Text = "Detalles";
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
