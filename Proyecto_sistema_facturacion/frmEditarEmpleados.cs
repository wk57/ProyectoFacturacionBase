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
    public partial class frmEditarEmpleados : MaterialForm
    {
        public frmEditarEmpleados()
        {
            InitializeComponent();
        }

        public int idEmpleado { get; set; }

        private void frmEditarEmpleados_Load(object sender, EventArgs e)
        {
            if (idEmpleado == 0)
            {
                lblTitulo.Text = "Ingeso Nuevo Empleado";
            }
            else
            {
                lblTitulo.Text = "Modificar Empleado";
                txtIdEmpleado.Text = idEmpleado.ToString();
                txtNombreEmpleado.Text = "Nombre 1 Apellido";
                txtDocumentoEmpleado.Text = "1040A57903";
                txtDireccionEmpleado.Text = "Dirreción carrera calle";
                txtTelefonoEmpleado.Text = "1234567";
                txtEmailEmpleado.Text = "Email";
                cbRolEmpleado.Text = "Rol Emp";
                
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
