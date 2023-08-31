using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_sistema_facturacion
{
    public partial class frmListaInformes : Form
    {
        public frmListaInformes()
        {
            InitializeComponent();
        }
        public void llenarGrid()
        {
            for (int i = 1; i < 10; i++)
            {
                dgInformes.Rows.Add(i, $" Informe {i} ", $"{DateTime.Now}");
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGenerarInforme Informe = new frmGenerarInforme();
            Informe.idInforme = 0;
            Informe.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaInformes_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void dgInformes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgInformes.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgInformes.CurrentRow.Index;
                if (MessageBox.Show("Seguro que desea borrar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"Borrando indice {e.RowIndex} ID {dgInformes[0, posActual].Value.ToString()}");
            }
            if (dgInformes.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgInformes.CurrentRow.Index;
                frmGenerarInforme Informe = new frmGenerarInforme();
                Informe.idInforme = int.Parse(dgInformes[0, posActual].Value.ToString());
                Informe.ShowDialog();
            }
        }
    }
}
