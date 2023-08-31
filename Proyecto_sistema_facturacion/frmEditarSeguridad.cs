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
    public partial class frmEditarSeguridad : MaterialForm
    {
        public frmEditarSeguridad()
        {
            InitializeComponent();
        }
        public int idSeguridad { get; set; }

        private void frmEditarSeguridad_Load(object sender, EventArgs e)
        {
            if (idSeguridad == 0)
            {
                lblTitulo.Text = "Ingeso Nuevo ";
            }
            else
            {
                lblTitulo.Text = "Modificar Empleado";
                txtUsuario.Text = "Usuario";
                txtContraseña.Text = "123465789";

            }
        }
            private void btnActualizar_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Edicion de datos exitosa");
            }

            private void btnSalir_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }

