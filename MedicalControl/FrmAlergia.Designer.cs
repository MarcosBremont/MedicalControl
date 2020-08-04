namespace MedicalControl
{
    partial class FrmAlergia
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.txtnombrealergia = new System.Windows.Forms.TextBox();
            this.lblnombrealergia = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(188, 251);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(84, 35);
            this.BtnCerrar.TabIndex = 17;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(65, 251);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(87, 35);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click_1);
            // 
            // txtnombrealergia
            // 
            this.txtnombrealergia.Location = new System.Drawing.Point(187, 174);
            this.txtnombrealergia.Name = "txtnombrealergia";
            this.txtnombrealergia.Size = new System.Drawing.Size(100, 20);
            this.txtnombrealergia.TabIndex = 12;
            this.txtnombrealergia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombrealergia_KeyPress);
            // 
            // lblnombrealergia
            // 
            this.lblnombrealergia.AutoSize = true;
            this.lblnombrealergia.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrealergia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnombrealergia.Location = new System.Drawing.Point(16, 175);
            this.lblnombrealergia.Name = "lblnombrealergia";
            this.lblnombrealergia.Size = new System.Drawing.Size(165, 19);
            this.lblnombrealergia.TabIndex = 10;
            this.lblnombrealergia.Text = "Nombre de la Alergia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedicalControl.Properties.Resources.flu;
            this.pictureBox1.Location = new System.Drawing.Point(119, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // FrmAlergia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(339, 388);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.txtnombrealergia);
            this.Controls.Add(this.lblnombrealergia);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlergia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAlergia";
            this.Load += new System.EventHandler(this.FrmAlergia_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAlergia_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button BtnCerrar;
        protected System.Windows.Forms.Button BtnAgregar;
        protected System.Windows.Forms.TextBox txtnombrealergia;
        protected System.Windows.Forms.Label lblnombrealergia;
        protected System.Windows.Forms.PictureBox pictureBox1;
    }
}