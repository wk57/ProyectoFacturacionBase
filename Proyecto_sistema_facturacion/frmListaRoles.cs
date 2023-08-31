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
    public partial class frmListaRoles : Form
    {
        public frmListaRoles()
        {
            InitializeComponent();
        }

        public void llenarGrid()
        {
            for (int i = 1; i < 10; i++)
            {
                dgRoles.Rows.Add(i, " Nombre rol", "Descripcion Rol");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarRoles Rol = new frmEditarRoles();
            Rol.idRol = 0;
            Rol.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRoles.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgRoles.CurrentRow.Index;
                if (MessageBox.Show("Seguro que desea borrar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"Borrando indice {e.RowIndex} ID {dgRoles[0, posActual].Value.ToString()}");
            }
            if (dgRoles.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgRoles.CurrentRow.Index;
                frmEditarRoles Rol = new frmEditarRoles();
                Rol.idRol = int.Parse(dgRoles[0, posActual].Value.ToString());
                Rol.ShowDialog();
            }
        }

        private void frmListaRoles_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }
    }
}
