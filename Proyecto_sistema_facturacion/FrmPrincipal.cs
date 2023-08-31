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
    public partial class FrmPrincipal : MaterialForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void AbrirForm(Form formHijo) //funcion comun para hacer llamado de formularios
        {
            if (this.pnlContenedor.Controls.Count> 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmListaClientes listaClientes = new frmListaClientes();
            AbrirForm(listaClientes);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

            frmListaProductos listaProductos = new frmListaProductos();
            AbrirForm(listaProductos);
            
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmListaCategorias listaCategorias = new frmListaCategorias();
            AbrirForm(listaCategorias);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmListaFacturas listaFacturas = new frmListaFacturas();
            AbrirForm(listaFacturas);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmListaInformes listaInformes = new frmListaInformes();
            AbrirForm(listaInformes);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmListaEmpleados listaEmpleados = new frmListaEmpleados();
            AbrirForm(listaEmpleados);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmListaRoles listaRoles = new frmListaRoles();
            AbrirForm(listaRoles);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            frmListaSeguridad listaSeguridad = new frmListaSeguridad();
            AbrirForm(listaSeguridad);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAyuda ventanaAyuda = new frmAyuda();
            AbrirForm(ventanaAyuda);
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            frmAcercaDE ventanaAcerca = new frmAcercaDE();
            AbrirForm(ventanaAcerca);
        }
    }
}
