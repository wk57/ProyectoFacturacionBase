namespace Proyecto_sistema_facturacion
{
    partial class frmEditarRoles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdRol = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombreRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbDescripcionRol = new System.Windows.Forms.TextBox();
            this.txtDescripcionRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtIdRol
            // 
            this.txtIdRol.Location = new System.Drawing.Point(56, 148);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.Size = new System.Drawing.Size(100, 20);
            this.txtIdRol.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Amiri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(180, 73);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(149, 58);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Rol Empleados";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Depth = 0;
            this.txtNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRol.Hint = "Nombre Rol";
            this.txtNombreRol.Location = new System.Drawing.Point(56, 191);
            this.txtNombreRol.MaxLength = 32767;
            this.txtNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.PasswordChar = '\0';
            this.txtNombreRol.SelectedText = "";
            this.txtNombreRol.SelectionLength = 0;
            this.txtNombreRol.SelectionStart = 0;
            this.txtNombreRol.Size = new System.Drawing.Size(306, 23);
            this.txtNombreRol.TabIndex = 2;
            this.txtNombreRol.TabStop = false;
            this.txtNombreRol.UseSystemPasswordChar = false;
            // 
            // tbDescripcionRol
            // 
            this.tbDescripcionRol.Location = new System.Drawing.Point(56, 261);
            this.tbDescripcionRol.Multiline = true;
            this.tbDescripcionRol.Name = "tbDescripcionRol";
            this.tbDescripcionRol.Size = new System.Drawing.Size(396, 82);
            this.tbDescripcionRol.TabIndex = 4;
            // 
            // txtDescripcionRol
            // 
            this.txtDescripcionRol.Depth = 0;
            this.txtDescripcionRol.Hint = "";
            this.txtDescripcionRol.Location = new System.Drawing.Point(56, 232);
            this.txtDescripcionRol.MaxLength = 32767;
            this.txtDescripcionRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcionRol.Name = "txtDescripcionRol";
            this.txtDescripcionRol.PasswordChar = '\0';
            this.txtDescripcionRol.SelectedText = "";
            this.txtDescripcionRol.SelectionLength = 0;
            this.txtDescripcionRol.SelectionStart = 0;
            this.txtDescripcionRol.Size = new System.Drawing.Size(195, 23);
            this.txtDescripcionRol.TabIndex = 5;
            this.txtDescripcionRol.TabStop = false;
            this.txtDescripcionRol.Text = "Descipción detallada de Rol";
            this.txtDescripcionRol.UseSystemPasswordChar = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(121, 369);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(281, 369);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmEditarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtDescripcionRol);
            this.Controls.Add(this.tbDescripcionRol);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtIdRol);
            this.Name = "frmEditarRoles";
            this.Text = "frmEditarRoles";
            this.Load += new System.EventHandler(this.frmEditarRoles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdRol;
        private System.Windows.Forms.Label lblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreRol;
        private System.Windows.Forms.TextBox tbDescripcionRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcionRol;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}