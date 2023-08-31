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
    public partial class frmListaSeguridad : Form
    {
        public frmListaSeguridad()
        {
            InitializeComponent();
        }

        public void llenarGrid()
        {
            for (int i = 1; i < 10; i++)
            {
                dgSeguridad.Rows.Add(i, $" Nombre {i} Apellido1 Apellido2", $"Usuario {i}", $"Contraseña {i}");
            }
        }

        private void frmListaSeguridad_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarSeguridad Seguridad = new frmEditarSeguridad();
            Seguridad.idSeguridad = 0;
            Seguridad.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgSeguridad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgSeguridad.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgSeguridad.CurrentRow.Index;
                if (MessageBox.Show("Seguro que desea borrar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"Borrando indice {e.RowIndex} ID {dgSeguridad[0, posActual].Value.ToString()}");
            }
            if (dgSeguridad.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgSeguridad.CurrentRow.Index;
                frmEditarSeguridad Seguridad = new frmEditarSeguridad();
                Seguridad.idSeguridad = int.Parse(dgSeguridad[0, posActual].Value.ToString());
                Seguridad.ShowDialog();
            }
        }
    }
}
