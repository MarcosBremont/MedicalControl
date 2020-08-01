namespace MedicalControl
{
    partial class FrmCorreo
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
            this.txtnombreclinica = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.lblaadjunto = new System.Windows.Forms.Label();
            this.txtadjunto = new System.Windows.Forms.TextBox();
            this.btnadjuntar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtremitente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtasunto = new System.Windows.Forms.TextBox();
            this.txtcc = new System.Windows.Forms.TextBox();
            this.rtbmensaje = new System.Windows.Forms.TextBox();
            this.txtpara = new System.Windows.Forms.TextBox();
            this.lblasunto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpara = new System.Windows.Forms.Label();
            this.btnenviar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombreclinica
            // 
            this.txtnombreclinica.Location = new System.Drawing.Point(520, 88);
            this.txtnombreclinica.Name = "txtnombreclinica";
            this.txtnombreclinica.Size = new System.Drawing.Size(186, 20);
            this.txtnombreclinica.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(386, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 19);
            this.label10.TabIndex = 83;
            this.label10.Text = "Nombre Clinica:";
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btncerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncerrar.Location = new System.Drawing.Point(442, 406);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(127, 42);
            this.btncerrar.TabIndex = 82;
            this.btncerrar.Text = "    Cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            // 
            // lblaadjunto
            // 
            this.lblaadjunto.AutoSize = true;
            this.lblaadjunto.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaadjunto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblaadjunto.Location = new System.Drawing.Point(396, 211);
            this.lblaadjunto.Name = "lblaadjunto";
            this.lblaadjunto.Size = new System.Drawing.Size(82, 19);
            this.lblaadjunto.TabIndex = 81;
            this.lblaadjunto.Text = "A. Adjunto";
            // 
            // txtadjunto
            // 
            this.txtadjunto.Location = new System.Drawing.Point(480, 214);
            this.txtadjunto.Name = "txtadjunto";
            this.txtadjunto.Size = new System.Drawing.Size(186, 20);
            this.txtadjunto.TabIndex = 80;
            // 
            // btnadjuntar
            // 
            this.btnadjuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnadjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadjuntar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadjuntar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadjuntar.Location = new System.Drawing.Point(671, 209);
            this.btnadjuntar.Name = "btnadjuntar";
            this.btnadjuntar.Size = new System.Drawing.Size(35, 27);
            this.btnadjuntar.TabIndex = 79;
            this.btnadjuntar.Text = "....";
            this.btnadjuntar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnadjuntar.UseVisualStyleBackColor = false;
            this.btnadjuntar.Click += new System.EventHandler(this.btnadjuntar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(94, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 78;
            this.label8.Text = "Tu Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(196, 166);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(132, 20);
            this.txtnombre.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(94, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 76;
            this.label7.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(94, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 75;
            this.label6.Text = "Remitente";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(196, 128);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(132, 20);
            this.txtpassword.TabIndex = 74;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtremitente
            // 
            this.txtremitente.Location = new System.Drawing.Point(196, 90);
            this.txtremitente.Name = "txtremitente";
            this.txtremitente.Size = new System.Drawing.Size(132, 20);
            this.txtremitente.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(249, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 29);
            this.label5.TabIndex = 72;
            this.label5.Text = "ENVIAR CORREO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(94, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 70;
            this.label4.Text = "Mensaje:";
            // 
            // txtasunto
            // 
            this.txtasunto.Location = new System.Drawing.Point(520, 162);
            this.txtasunto.Name = "txtasunto";
            this.txtasunto.Size = new System.Drawing.Size(186, 20);
            this.txtasunto.TabIndex = 69;
            // 
            // txtcc
            // 
            this.txtcc.Location = new System.Drawing.Point(140, 204);
            this.txtcc.Name = "txtcc";
            this.txtcc.Size = new System.Drawing.Size(186, 20);
            this.txtcc.TabIndex = 68;
            // 
            // rtbmensaje
            // 
            this.rtbmensaje.Location = new System.Drawing.Point(94, 256);
            this.rtbmensaje.Multiline = true;
            this.rtbmensaje.Name = "rtbmensaje";
            this.rtbmensaje.Size = new System.Drawing.Size(612, 125);
            this.rtbmensaje.TabIndex = 67;
            // 
            // txtpara
            // 
            this.txtpara.Location = new System.Drawing.Point(520, 125);
            this.txtpara.Name = "txtpara";
            this.txtpara.Size = new System.Drawing.Size(186, 20);
            this.txtpara.TabIndex = 66;
            // 
            // lblasunto
            // 
            this.lblasunto.AutoSize = true;
            this.lblasunto.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblasunto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblasunto.Location = new System.Drawing.Point(451, 159);
            this.lblasunto.Name = "lblasunto";
            this.lblasunto.Size = new System.Drawing.Size(63, 19);
            this.lblasunto.TabIndex = 65;
            this.lblasunto.Text = "Asunto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(94, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 64;
            this.label2.Text = "CC:";
            // 
            // lblpara
            // 
            this.lblpara.AutoSize = true;
            this.lblpara.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpara.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblpara.Location = new System.Drawing.Point(467, 122);
            this.lblpara.Name = "lblpara";
            this.lblpara.Size = new System.Drawing.Size(48, 19);
            this.lblpara.TabIndex = 63;
            this.lblpara.Text = "Para:";
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnenviar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnenviar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnenviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnenviar.Location = new System.Drawing.Point(229, 406);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(137, 43);
            this.btnenviar.TabIndex = 62;
            this.btnenviar.Text = "     Enviar";
            this.btnenviar.UseVisualStyleBackColor = false;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(452, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // FrmCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.txtnombreclinica);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.lblaadjunto);
            this.Controls.Add(this.txtadjunto);
            this.Controls.Add(this.btnadjuntar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtremitente);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtasunto);
            this.Controls.Add(this.txtcc);
            this.Controls.Add(this.rtbmensaje);
            this.Controls.Add(this.txtpara);
            this.Controls.Add(this.lblasunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpara);
            this.Controls.Add(this.btnenviar);
            this.Name = "FrmCorreo";
            this.Text = "FrmCorreo";
            this.Load += new System.EventHandler(this.FrmCorreo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtnombreclinica;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Label lblaadjunto;
        public System.Windows.Forms.TextBox txtadjunto;
        private System.Windows.Forms.Button btnadjuntar;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtpassword;
        public System.Windows.Forms.TextBox txtremitente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtasunto;
        public System.Windows.Forms.TextBox txtcc;
        public System.Windows.Forms.TextBox rtbmensaje;
        public System.Windows.Forms.TextBox txtpara;
        private System.Windows.Forms.Label lblasunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpara;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}