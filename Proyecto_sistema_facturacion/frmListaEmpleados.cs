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
    public partial class frmListaEmpleados : Form
    {
        public frmListaEmpleados()
        {
            InitializeComponent();
        }

        public void llenarGrid()
        {
            for (int i = 1; i < 10; i++)
            {
                dgEmpleados.Rows.Add(i, $" Nombre {i} Apellido1", $"{i * 12345}", "Dirección",
                    $"{i * 1234}", $"Email{i}", $"Rol{i}", DateTime.Now, DateTime.Now, $"Datos Adicionales");
            }
        }

        private void frmListaEmpleados_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }
       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarEmpleados Empleado = new frmEditarEmpleados();
            Empleado.idEmpleado = 0;
            Empleado.ShowDialog();
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgEmpleados.CurrentRow.Index;
                if (MessageBox.Show("Seguro que desea borrar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"Borrando indice {e.RowIndex} ID {dgEmpleados[0, posActual].Value.ToString()}");
            }
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgEmpleados.CurrentRow.Index;
                frmEditarEmpleados Empleado = new frmEditarEmpleados();
                Empleado.idEmpleado = int.Parse(dgEmpleados[0, posActual].Value.ToString());
                Empleado.ShowDialog();
            }
        }
    }
}
