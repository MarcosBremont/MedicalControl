namespace MedicalControl
{
    partial class FrmRegistro
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
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.panelregistro = new System.Windows.Forms.Panel();
            this.pictureBoxregistro = new System.Windows.Forms.PictureBox();
            this.lblregistro = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.txtnombreusuario = new System.Windows.Forms.TextBox();
            this.pBapellido = new System.Windows.Forms.PictureBox();
            this.pBnombre = new System.Windows.Forms.PictureBox();
            this.pBemail = new System.Windows.Forms.PictureBox();
            this.pBcontrasena = new System.Windows.Forms.PictureBox();
            this.pBusuario = new System.Windows.Forms.PictureBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.panelregistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxregistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBapellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBnombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBcontrasena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtapellido
            // 
            this.txtapellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtapellido.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtapellido.ForeColor = System.Drawing.Color.Black;
            this.txtapellido.Location = new System.Drawing.Point(411, 92);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(116, 24);
            this.txtapellido.TabIndex = 25;
            this.txtapellido.Text = "APELLIDO";
            this.txtapellido.Enter += new System.EventHandler(this.txtapellido_Enter);
            this.txtapellido.Leave += new System.EventHandler(this.txtapellido_Leave);
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtnombre.ForeColor = System.Drawing.Color.Black;
            this.txtnombre.Location = new System.Drawing.Point(409, 40);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(116, 24);
            this.txtnombre.TabIndex = 24;
            this.txtnombre.Text = "NOMBRE";
            this.txtnombre.Enter += new System.EventHandler(this.txtnombre_Enter);
            this.txtnombre.Leave += new System.EventHandler(this.txtnombre_Leave);
            // 
            // btnminimizar
            // 
            this.btnminimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnminimizar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnminimizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnminimizar.Location = new System.Drawing.Point(767, 58);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(23, 34);
            this.btnminimizar.TabIndex = 22;
            this.btnminimizar.Text = "-";
            this.btnminimizar.UseVisualStyleBackColor = false;
            // 
            // panelregistro
            // 
            this.panelregistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.panelregistro.Controls.Add(this.pictureBoxregistro);
            this.panelregistro.Location = new System.Drawing.Point(-2, -24);
            this.panelregistro.Name = "panelregistro";
            this.panelregistro.Size = new System.Drawing.Size(248, 334);
            this.panelregistro.TabIndex = 23;
            this.panelregistro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelregistro_MouseDown);
            // 
            // pictureBoxregistro
            // 
            this.pictureBoxregistro.Image = global::MedicalControl.Properties.Resources.MEDICAL_CONTROL__1__removebg;
            this.pictureBoxregistro.Location = new System.Drawing.Point(-19, 39);
            this.pictureBoxregistro.Name = "pictureBoxregistro";
            this.pictureBoxregistro.Size = new System.Drawing.Size(278, 249);
            this.pictureBoxregistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxregistro.TabIndex = 18;
            this.pictureBoxregistro.TabStop = false;
            this.pictureBoxregistro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxregistro_MouseDown);
            // 
            // lblregistro
            // 
            this.lblregistro.AutoSize = true;
            this.lblregistro.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblregistro.ForeColor = System.Drawing.Color.White;
            this.lblregistro.Location = new System.Drawing.Point(500, 3);
            this.lblregistro.Name = "lblregistro";
            this.lblregistro.Size = new System.Drawing.Size(96, 25);
            this.lblregistro.TabIndex = 0;
            this.lblregistro.Text = "Registro";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.Window;
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.Location = new System.Drawing.Point(608, 116);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(116, 24);
            this.txtemail.TabIndex = 28;
            this.txtemail.Text = "E-MAIL";
            this.txtemail.Enter += new System.EventHandler(this.txtemail_Enter);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.BackColor = System.Drawing.SystemColors.Window;
            this.txtcontrasena.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtcontrasena.ForeColor = System.Drawing.Color.Black;
            this.txtcontrasena.Location = new System.Drawing.Point(609, 62);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(116, 24);
            this.txtcontrasena.TabIndex = 27;
            this.txtcontrasena.Text = "CONTRASENA";
            this.txtcontrasena.Enter += new System.EventHandler(this.txtcontrasena_Enter);
            this.txtcontrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontrasena_KeyPress);
            this.txtcontrasena.Leave += new System.EventHandler(this.txtcontrasena_Leave);
            // 
            // txtnombreusuario
            // 
            this.txtnombreusuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtnombreusuario.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtnombreusuario.ForeColor = System.Drawing.Color.Black;
            this.txtnombreusuario.Location = new System.Drawing.Point(413, 144);
            this.txtnombreusuario.Name = "txtnombreusuario";
            this.txtnombreusuario.Size = new System.Drawing.Size(116, 24);
            this.txtnombreusuario.TabIndex = 26;
            this.txtnombreusuario.Text = "USUARIO";
            this.txtnombreusuario.Enter += new System.EventHandler(this.txtnombreusuario_Enter);
            this.txtnombreusuario.Leave += new System.EventHandler(this.txtnombreusuario_Leave);
            // 
            // pBapellido
            // 
            this.pBapellido.Image = global::MedicalControl.Properties.Resources.nombre;
            this.pBapellido.Location = new System.Drawing.Point(357, 79);
            this.pBapellido.Name = "pBapellido";
            this.pBapellido.Size = new System.Drawing.Size(42, 43);
            this.pBapellido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBapellido.TabIndex = 35;
            this.pBapellido.TabStop = false;
            // 
            // pBnombre
            // 
            this.pBnombre.Image = global::MedicalControl.Properties.Resources.nombre;
            this.pBnombre.Location = new System.Drawing.Point(355, 27);
            this.pBnombre.Name = "pBnombre";
            this.pBnombre.Size = new System.Drawing.Size(42, 43);
            this.pBnombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBnombre.TabIndex = 33;
            this.pBnombre.TabStop = false;
            // 
            // pBemail
            // 
            this.pBemail.Image = global::MedicalControl.Properties.Resources.gmail;
            this.pBemail.Location = new System.Drawing.Point(554, 105);
            this.pBemail.Name = "pBemail";
            this.pBemail.Size = new System.Drawing.Size(42, 43);
            this.pBemail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBemail.TabIndex = 34;
            this.pBemail.TabStop = false;
            // 
            // pBcontrasena
            // 
            this.pBcontrasena.Image = global::MedicalControl.Properties.Resources.blocked;
            this.pBcontrasena.Location = new System.Drawing.Point(555, 50);
            this.pBcontrasena.Name = "pBcontrasena";
            this.pBcontrasena.Size = new System.Drawing.Size(42, 43);
            this.pBcontrasena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBcontrasena.TabIndex = 32;
            this.pBcontrasena.TabStop = false;
            // 
            // pBusuario
            // 
            this.pBusuario.Image = global::MedicalControl.Properties.Resources.nombre;
            this.pBusuario.Location = new System.Drawing.Point(358, 132);
            this.pBusuario.Name = "pBusuario";
            this.pBusuario.Size = new System.Drawing.Size(42, 43);
            this.pBusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBusuario.TabIndex = 31;
            this.pBusuario.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.BtnSalir.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSalir.Location = new System.Drawing.Point(574, 229);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(103, 35);
            this.BtnSalir.TabIndex = 58;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(408, 229);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 35);
            this.btnEliminar.TabIndex = 57;
            this.btnEliminar.Text = "Registrar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmin.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmin.Location = new System.Drawing.Point(742, 0);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(23, 26);
            this.btnmin.TabIndex = 59;
            this.btnmin.Text = "-";
            this.btnmin.UseVisualStyleBackColor = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(764, 291);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pBapellido);
            this.Controls.Add(this.lblregistro);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.pBnombre);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.pBemail);
            this.Controls.Add(this.panelregistro);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.pBcontrasena);
            this.Controls.Add(this.pBusuario);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtnombreusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmRegistro_MouseDown);
            this.panelregistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxregistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBapellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBnombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBcontrasena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBapellido;
        public System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.PictureBox pBnombre;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnminimizar;
        private System.Windows.Forms.PictureBox pBemail;
        private System.Windows.Forms.Panel panelregistro;
        private System.Windows.Forms.PictureBox pictureBoxregistro;
        private System.Windows.Forms.Label lblregistro;
        public System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.PictureBox pBcontrasena;
        private System.Windows.Forms.PictureBox pBusuario;
        public System.Windows.Forms.TextBox txtcontrasena;
        public System.Windows.Forms.TextBox txtnombreusuario;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnmin;
    }
}