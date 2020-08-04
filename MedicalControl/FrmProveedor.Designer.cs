namespace MedicalControl
{
    partial class FrmProveedor
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
            this.lblespecialidad = new System.Windows.Forms.Label();
            this.txtubicacion = new System.Windows.Forms.TextBox();
            this.txtnombreproveedor = new System.Windows.Forms.TextBox();
            this.lblnombreproveedor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.mtbtelefonoproveedor = new System.Windows.Forms.MaskedTextBox();
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
            this.BtnCerrar.Location = new System.Drawing.Point(366, 266);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(104, 35);
            this.BtnCerrar.TabIndex = 15;
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
            this.BtnAgregar.Location = new System.Drawing.Point(171, 266);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(102, 35);
            this.BtnAgregar.TabIndex = 14;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lblespecialidad
            // 
            this.lblespecialidad.AutoSize = true;
            this.lblespecialidad.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblespecialidad.ForeColor = System.Drawing.Color.Black;
            this.lblespecialidad.Location = new System.Drawing.Point(345, 185);
            this.lblespecialidad.Name = "lblespecialidad";
            this.lblespecialidad.Size = new System.Drawing.Size(79, 19);
            this.lblespecialidad.TabIndex = 13;
            this.lblespecialidad.Text = "Ubicacion";
            // 
            // txtubicacion
            // 
            this.txtubicacion.Location = new System.Drawing.Point(428, 184);
            this.txtubicacion.Name = "txtubicacion";
            this.txtubicacion.Size = new System.Drawing.Size(124, 20);
            this.txtubicacion.TabIndex = 12;
            // 
            // txtnombreproveedor
            // 
            this.txtnombreproveedor.Location = new System.Drawing.Point(233, 142);
            this.txtnombreproveedor.Name = "txtnombreproveedor";
            this.txtnombreproveedor.Size = new System.Drawing.Size(100, 20);
            this.txtnombreproveedor.TabIndex = 11;
            this.txtnombreproveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombreproveedor_KeyPress);
            // 
            // lblnombreproveedor
            // 
            this.lblnombreproveedor.AutoSize = true;
            this.lblnombreproveedor.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreproveedor.ForeColor = System.Drawing.Color.Black;
            this.lblnombreproveedor.Location = new System.Drawing.Point(50, 140);
            this.lblnombreproveedor.Name = "lblnombreproveedor";
            this.lblnombreproveedor.Size = new System.Drawing.Size(176, 19);
            this.lblnombreproveedor.TabIndex = 10;
            this.lblnombreproveedor.Text = "Nombre del Proveedor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedicalControl.Properties.Resources.medicine;
            this.pictureBox1.Location = new System.Drawing.Point(251, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Telefono del Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(345, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Correo";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(428, 143);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(124, 20);
            this.txtcorreo.TabIndex = 18;
            // 
            // mtbtelefonoproveedor
            // 
            this.mtbtelefonoproveedor.Location = new System.Drawing.Point(233, 184);
            this.mtbtelefonoproveedor.Mask = "000-000-0000";
            this.mtbtelefonoproveedor.Name = "mtbtelefonoproveedor";
            this.mtbtelefonoproveedor.Size = new System.Drawing.Size(100, 20);
            this.mtbtelefonoproveedor.TabIndex = 20;
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 332);
            this.Controls.Add(this.mtbtelefonoproveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.lblespecialidad);
            this.Controls.Add(this.txtubicacion);
            this.Controls.Add(this.txtnombreproveedor);
            this.Controls.Add(this.lblnombreproveedor);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmProveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button BtnCerrar;
        protected System.Windows.Forms.Button BtnAgregar;
        protected System.Windows.Forms.Label lblespecialidad;
        protected System.Windows.Forms.TextBox txtubicacion;
        protected System.Windows.Forms.TextBox txtnombreproveedor;
        protected System.Windows.Forms.Label lblnombreproveedor;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.MaskedTextBox mtbtelefonoproveedor;
    }
}