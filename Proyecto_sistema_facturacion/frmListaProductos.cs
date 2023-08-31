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
    public partial class frmListaProductos : Form
    {
        public frmListaProductos()
        {
            InitializeComponent();
        }
        public void llenarGrid()
        {
            for (int i = 1; i < 10; i++)
            {
                dgProductos.Rows.Add(i, $" Nombre Producto {i}", $"{i * 123}", $"{i * 1}", $"{i * 2}",$"{i*3}","Categoria", "Ruta Imagen1", "Detalles Producto");
            }
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarProducto Producto = new frmEditarProducto();
            Producto.IdProducto = 0;
            Producto.ShowDialog();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgProductos.CurrentRow.Index;
                if (MessageBox.Show("Seguro que desea borrar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"Borrando indice {e.RowIndex} ID {dgProductos[0, posActual].Value.ToString()}");
            }
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgProductos.CurrentRow.Index;
                frmEditarProducto Producto = new frmEditarProducto();
                Producto.IdProducto = int.Parse(dgProductos[0, posActual].Value.ToString());
                Producto.ShowDialog();
            }
        }
    }
}
