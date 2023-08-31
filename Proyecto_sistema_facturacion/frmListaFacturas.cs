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
    public partial class frmListaFacturas : Form
    {
        public frmListaFacturas()
        {
            InitializeComponent();
        }
        public void llenarGrid()
        {
            for (int i = 1; i < 10; i++)
            {
                dgFacturas.Rows.Add(i, $" NombreC {i} Apellido1 Apellido2",  $" NombreE {i} Apellido1", 
                    $"{i * 20}", $"{i * 19}", $"{i * 123}", $"EFactura{i}");
            }
        }

        private void frmListaFactuas_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void dgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgFacturas.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgFacturas.CurrentRow.Index;
                if (MessageBox.Show("Seguro que desea borrar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"Borrando indice {e.RowIndex} ID {dgFacturas[0, posActual].Value.ToString()}");
            }
            if (dgFacturas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgFacturas.CurrentRow.Index;
                frmEditarFacturas Factura = new frmEditarFacturas();
                Factura.idFactura = int.Parse(dgFacturas[0, posActual].Value.ToString());
                Factura.ShowDialog();
            }
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            frmEditarFacturas Factura = new frmEditarFacturas();
            Factura.idFactura = 0;
            Factura.ShowDialog();
        }
    }
}
