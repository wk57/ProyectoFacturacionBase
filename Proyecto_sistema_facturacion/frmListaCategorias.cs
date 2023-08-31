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
    public partial class frmListaCategorias : Form
    {
        public frmListaCategorias()
        {
            InitializeComponent();
        }
        public void llenarGrid()
        {
            for (int i = 1; i < 10; i++)
            {
                dgCategoriaProductos.Rows.Add(i, $" Nombre Categoria");
            }
        }

        private void frmListaCategorias_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarCategoria Categoria = new frmEditarCategoria();
            Categoria.idCategoriaProducto = 0;
            Categoria.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgCategoriaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCategoriaProductos.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgCategoriaProductos.CurrentRow.Index;
                if (MessageBox.Show("Seguro que desea borrar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"Borrando indice {e.RowIndex} ID {dgCategoriaProductos[0, posActual].Value.ToString()}");
            }
            if (dgCategoriaProductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgCategoriaProductos.CurrentRow.Index;
                frmEditarCategoria Categoria = new frmEditarCategoria();
                Categoria.idCategoriaProducto = int.Parse(dgCategoriaProductos[0, posActual].Value.ToString());
                Categoria.ShowDialog();
            }
        }
    }
}
