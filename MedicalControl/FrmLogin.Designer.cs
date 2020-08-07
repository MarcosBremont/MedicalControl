namespace MedicalControl
{
    partial class FrmLogin
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
            this.lbllogin = new System.Windows.Forms.Label();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.txtnombreusuario = new System.Windows.Forms.TextBox();
            this.lblregistro = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pBLogoCall = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.pBcontrasena = new System.Windows.Forms.PictureBox();
            this.pBusuario = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogoCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBcontrasena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.Color.Transparent;
            this.lbllogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.Color.White;
            this.lbllogin.Location = new System.Drawing.Point(455, 12);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(72, 22);
            this.lbllogin.TabIndex = 24;
            this.lbllogin.Text = "LOGIN";
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontrasena.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtcontrasena.Location = new System.Drawing.Point(459, 121);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(119, 23);
            this.txtcontrasena.TabIndex = 23;
            this.txtcontrasena.Text = "CONTRASENA";
            this.txtcontrasena.Enter += new System.EventHandler(this.txtcontrasena_Enter);
            this.txtcontrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontrasena_KeyPress);
            this.txtcontrasena.Leave += new System.EventHandler(this.txtcontrasena_Leave);
            // 
            // txtnombreusuario
            // 
            this.txtnombreusuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreusuario.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtnombreusuario.Location = new System.Drawing.Point(459, 79);
            this.txtnombreusuario.Name = "txtnombreusuario";
            this.txtnombreusuario.Size = new System.Drawing.Size(119, 23);
            this.txtnombreusuario.TabIndex = 22;
            this.txtnombreusuario.Text = "USUARIO";
            this.txtnombreusuario.Enter += new System.EventHandler(this.txtnombreusuario_Enter);
            this.txtnombreusuario.Leave += new System.EventHandler(this.txtnombreusuario_Leave);
            // 
            // lblregistro
            // 
            this.lblregistro.AutoSize = true;
            this.lblregistro.BackColor = System.Drawing.Color.Transparent;
            this.lblregistro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblregistro.ForeColor = System.Drawing.Color.White;
            this.lblregistro.Location = new System.Drawing.Point(343, 172);
            this.lblregistro.Name = "lblregistro";
            this.lblregistro.Size = new System.Drawing.Size(303, 17);
            this.lblregistro.TabIndex = 16;
            this.lblregistro.Text = "Si aun no te has registrado, hazlo dando click";
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnregistrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnregistrar.FlatAppearance.BorderSize = 0;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnregistrar.ForeColor = System.Drawing.Color.Red;
            this.btnregistrar.Location = new System.Drawing.Point(630, 163);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(58, 36);
            this.btnregistrar.TabIndex = 18;
            this.btnregistrar.Text = "aca";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.panel3.Controls.Add(this.pBLogoCall);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 330);
            this.panel3.TabIndex = 15;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // pBLogoCall
            // 
            this.pBLogoCall.Image = global::MedicalControl.Properties.Resources.MEDICAL_CONTROL__1__removebg;
            this.pBLogoCall.Location = new System.Drawing.Point(1, 29);
            this.pBLogoCall.Name = "pBLogoCall";
            this.pBLogoCall.Size = new System.Drawing.Size(249, 285);
            this.pBLogoCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBLogoCall.TabIndex = 13;
            this.pBLogoCall.TabStop = false;
            this.pBLogoCall.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBLogoCall_MouseDown);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(372, 258);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 35);
            this.btnEliminar.TabIndex = 55;
            this.btnEliminar.Text = "Iniciar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(525, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 56;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnminimizar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnminimizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnminimizar.Location = new System.Drawing.Point(758, 0);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(23, 26);
            this.btnminimizar.TabIndex = 57;
            this.btnminimizar.Text = "-";
            this.btnminimizar.UseVisualStyleBackColor = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // pBcontrasena
            // 
            this.pBcontrasena.Image = global::MedicalControl.Properties.Resources.blocked;
            this.pBcontrasena.Location = new System.Drawing.Point(422, 116);
            this.pBcontrasena.Name = "pBcontrasena";
            this.pBcontrasena.Size = new System.Drawing.Size(31, 33);
            this.pBcontrasena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBcontrasena.TabIndex = 21;
            this.pBcontrasena.TabStop = false;
            // 
            // pBusuario
            // 
            this.pBusuario.Image = global::MedicalControl.Properties.Resources.user;
            this.pBusuario.Location = new System.Drawing.Point(422, 74);
            this.pBusuario.Name = "pBusuario";
            this.pBusuario.Size = new System.Drawing.Size(31, 33);
            this.pBusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBusuario.TabIndex = 20;
            this.pBusuario.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtnombreusuario);
            this.Controls.Add(this.pBcontrasena);
            this.Controls.Add(this.pBusuario);
            this.Controls.Add(this.lblregistro);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBLogoCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBcontrasena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.TextBox txtnombreusuario;
        private System.Windows.Forms.PictureBox pBcontrasena;
        private System.Windows.Forms.PictureBox pBusuario;
        private System.Windows.Forms.Label lblregistro;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pBLogoCall;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnminimizar;
    }
}