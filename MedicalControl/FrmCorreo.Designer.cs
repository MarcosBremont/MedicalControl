﻿namespace MedicalControl
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
            this.lblaadjunto = new System.Windows.Forms.Label();
            this.txtadjunto = new System.Windows.Forms.TextBox();
            this.btnadjuntar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtremitente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtasunto = new System.Windows.Forms.TextBox();
            this.txtcc = new System.Windows.Forms.TextBox();
            this.rtbmensaje = new System.Windows.Forms.TextBox();
            this.txtpara = new System.Windows.Forms.TextBox();
            this.lblasunto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpara = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnenviar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblaadjunto
            // 
            this.lblaadjunto.AutoSize = true;
            this.lblaadjunto.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaadjunto.ForeColor = System.Drawing.Color.Black;
            this.lblaadjunto.Location = new System.Drawing.Point(619, 204);
            this.lblaadjunto.Name = "lblaadjunto";
            this.lblaadjunto.Size = new System.Drawing.Size(82, 19);
            this.lblaadjunto.TabIndex = 81;
            this.lblaadjunto.Text = "A. Adjunto";
            // 
            // txtadjunto
            // 
            this.txtadjunto.Location = new System.Drawing.Point(703, 203);
            this.txtadjunto.Name = "txtadjunto";
            this.txtadjunto.Size = new System.Drawing.Size(186, 20);
            this.txtadjunto.TabIndex = 80;
            // 
            // btnadjuntar
            // 
            this.btnadjuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(107)))), ((int)(((byte)(167)))));
            this.btnadjuntar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnadjuntar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadjuntar.ForeColor = System.Drawing.Color.White;
            this.btnadjuntar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadjuntar.Location = new System.Drawing.Point(894, 193);
            this.btnadjuntar.Name = "btnadjuntar";
            this.btnadjuntar.Size = new System.Drawing.Size(35, 41);
            this.btnadjuntar.TabIndex = 79;
            this.btnadjuntar.Text = "....";
            this.btnadjuntar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnadjuntar.UseVisualStyleBackColor = false;
            this.btnadjuntar.Click += new System.EventHandler(this.btnadjuntar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(188, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 76;
            this.label7.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(188, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 75;
            this.label6.Text = "Remitente";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(290, 153);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(132, 20);
            this.txtpassword.TabIndex = 74;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtremitente
            // 
            this.txtremitente.Location = new System.Drawing.Point(290, 103);
            this.txtremitente.Name = "txtremitente";
            this.txtremitente.Size = new System.Drawing.Size(132, 20);
            this.txtremitente.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(188, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 70;
            this.label4.Text = "Mensaje:";
            // 
            // txtasunto
            // 
            this.txtasunto.Location = new System.Drawing.Point(743, 153);
            this.txtasunto.Name = "txtasunto";
            this.txtasunto.Size = new System.Drawing.Size(186, 20);
            this.txtasunto.TabIndex = 69;
            // 
            // txtcc
            // 
            this.txtcc.Location = new System.Drawing.Point(290, 203);
            this.txtcc.Name = "txtcc";
            this.txtcc.Size = new System.Drawing.Size(186, 20);
            this.txtcc.TabIndex = 68;
            // 
            // rtbmensaje
            // 
            this.rtbmensaje.Location = new System.Drawing.Point(290, 263);
            this.rtbmensaje.Multiline = true;
            this.rtbmensaje.Name = "rtbmensaje";
            this.rtbmensaje.Size = new System.Drawing.Size(639, 125);
            this.rtbmensaje.TabIndex = 67;
            // 
            // txtpara
            // 
            this.txtpara.Location = new System.Drawing.Point(743, 103);
            this.txtpara.Name = "txtpara";
            this.txtpara.Size = new System.Drawing.Size(186, 20);
            this.txtpara.TabIndex = 66;
            // 
            // lblasunto
            // 
            this.lblasunto.AutoSize = true;
            this.lblasunto.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblasunto.ForeColor = System.Drawing.Color.Black;
            this.lblasunto.Location = new System.Drawing.Point(674, 154);
            this.lblasunto.Name = "lblasunto";
            this.lblasunto.Size = new System.Drawing.Size(63, 19);
            this.lblasunto.TabIndex = 65;
            this.lblasunto.Text = "Asunto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(188, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 64;
            this.label2.Text = "CC:";
            // 
            // lblpara
            // 
            this.lblpara.AutoSize = true;
            this.lblpara.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpara.ForeColor = System.Drawing.Color.Black;
            this.lblpara.Location = new System.Drawing.Point(690, 104);
            this.lblpara.Name = "lblpara";
            this.lblpara.Size = new System.Drawing.Size(48, 19);
            this.lblpara.TabIndex = 63;
            this.lblpara.Text = "Para:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(107)))), ((int)(((byte)(167)))));
            this.btnenviar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnenviar.Location = new System.Drawing.Point(462, 408);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(128, 48);
            this.btnenviar.TabIndex = 85;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = false;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedicalControl.Properties.Resources.gmail;
            this.pictureBox1.Location = new System.Drawing.Point(478, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 539);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.lblaadjunto);
            this.Controls.Add(this.txtadjunto);
            this.Controls.Add(this.btnadjuntar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtremitente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtasunto);
            this.Controls.Add(this.txtcc);
            this.Controls.Add(this.rtbmensaje);
            this.Controls.Add(this.txtpara);
            this.Controls.Add(this.lblasunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(903, 539);
            this.Name = "FrmCorreo";
            this.Text = "Correo";
            this.Load += new System.EventHandler(this.FrmCorreo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblaadjunto;
        public System.Windows.Forms.TextBox txtadjunto;
        private System.Windows.Forms.Button btnadjuntar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtpassword;
        public System.Windows.Forms.TextBox txtremitente;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtasunto;
        public System.Windows.Forms.TextBox txtcc;
        public System.Windows.Forms.TextBox rtbmensaje;
        public System.Windows.Forms.TextBox txtpara;
        private System.Windows.Forms.Label lblasunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpara;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}