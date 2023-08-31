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
    public partial class frmEditarCategoria : MaterialForm
    {
        public frmEditarCategoria()
        {
            InitializeComponent();
        }
        public int idCategoriaProducto { get; set; }

        private void frmEditarCategoria_Load(object sender, EventArgs e)
        {
            if (idCategoriaProducto == 0)
            {
                lblTitulo.Text = "Ingreso nueva categoria";
            }
            else
            {
                lblTitulo.Text = "Modifique categoria";
                txtIdCategoria.Text = idCategoriaProducto.ToString();
                txtNombreCategoria.Text = "nombre categoria";
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
