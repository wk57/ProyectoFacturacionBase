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
    public partial class frmEditarCliente : MaterialForm
    {
        public frmEditarCliente()
        {
            InitializeComponent();
        }
        public int idCliente { get; set; }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            if (idCliente == 0)
            {
                lblTitulo.Text = "Ingeso Nuevo Cliente";
            }
            else
            {
                lblTitulo.Text = "Modificar CLiente";
                txtIdCliente.Text = idCliente.ToString();
                txtNombreCliente.Text = "Nombre 1 Apellido";
                txtDocumento.Text = "1040A57903";
                txtDireccion.Text = "Dirreción carrera calle";
                txtTelefono.Text = "1234567";
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
