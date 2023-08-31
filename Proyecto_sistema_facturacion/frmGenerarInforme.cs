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
    public partial class frmGenerarInforme : MaterialForm
    {
        public frmGenerarInforme()
        {
            InitializeComponent();
        }
        public int idInforme { get; set; }  

        private void frmGenerarInforme_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informe Generado");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
