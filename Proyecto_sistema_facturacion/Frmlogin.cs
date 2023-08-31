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
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Respuesta = "";
            if (txtUsuario.Text != "" && txtContraseña.Text != string.Empty)
            {
                if (txtUsuario.Text == "admin" && txtContraseña.Text == "123")
                    Respuesta = "Victor Restrepo";

                if (Respuesta != "")
                {
                    MessageBox.Show("Bienvenido : " + Respuesta);
                    FrmPrincipal frmppal = new FrmPrincipal();
                    this.Hide();
                    frmppal.Show();
                }
            }
            else
            {
                MessageBox.Show("Es requerido ingresar un usuario y contraseña");
            }
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
