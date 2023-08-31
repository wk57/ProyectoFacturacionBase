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
    public partial class frmEditarRoles : MaterialForm
    {
        public frmEditarRoles()
        {
            InitializeComponent();
        }
        public int idRol {get;set;}
        private void frmEditarRoles_Load(object sender, EventArgs e)
        {
            if (idRol == 0)
            {
                lblTitulo.Text = "Ingeso Rol";
            }
            else
            {
                lblTitulo.Text = "Modificar Rol";
                txtIdRol.Text = idRol.ToString();
                txtNombreRol.Text = "Nombre Rol";
                txtDescripcionRol.Text = "Descripcion Rol";
                
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rol Actualizado");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
