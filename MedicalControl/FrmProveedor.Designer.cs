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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtubicacionproveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombreproveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblidproveedor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcodigoproveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminarProveedores = new System.Windows.Forms.Button();
            this.dgvproveedor = new System.Windows.Forms.DataGridView();
            this.idt_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UbicacionProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.White;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Black;
            this.BtnCerrar.Location = new System.Drawing.Point(815, 442);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(102, 35);
            this.BtnCerrar.TabIndex = 15;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.White;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Location = new System.Drawing.Point(194, 409);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(102, 35);
            this.BtnAgregar.TabIndex = 14;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedicalControl.Properties.Resources.medicine;
            this.pictureBox1.Location = new System.Drawing.Point(404, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // mtxtTelefono
            // 
            this.mtxtTelefono.Location = new System.Drawing.Point(460, 321);
            this.mtxtTelefono.Mask = "000-000-0000";
            this.mtxtTelefono.Name = "mtxtTelefono";
            this.mtxtTelefono.Size = new System.Drawing.Size(100, 20);
            this.mtxtTelefono.TabIndex = 51;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(616, 321);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(114, 20);
            this.txtcorreo.TabIndex = 49;
            // 
            // txtubicacionproveedor
            // 
            this.txtubicacionproveedor.Location = new System.Drawing.Point(466, 362);
            this.txtubicacionproveedor.Name = "txtubicacionproveedor";
            this.txtubicacionproveedor.Size = new System.Drawing.Size(94, 20);
            this.txtubicacionproveedor.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(561, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "Correo";
            // 
            // txtnombreproveedor
            // 
            this.txtnombreproveedor.Location = new System.Drawing.Point(225, 362);
            this.txtnombreproveedor.Name = "txtnombreproveedor";
            this.txtnombreproveedor.Size = new System.Drawing.Size(89, 20);
            this.txtnombreproveedor.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nombre Proveedor";
            // 
            // lblidproveedor
            // 
            this.lblidproveedor.AutoSize = true;
            this.lblidproveedor.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidproveedor.ForeColor = System.Drawing.Color.White;
            this.lblidproveedor.Location = new System.Drawing.Point(92, 322);
            this.lblidproveedor.Name = "lblidproveedor";
            this.lblidproveedor.Size = new System.Drawing.Size(126, 18);
            this.lblidproveedor.TabIndex = 41;
            this.lblidproveedor.Text = "Codigo Proveedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(318, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "Ubicacion Proveedor";
            // 
            // txtcodigoproveedor
            // 
            this.txtcodigoproveedor.Location = new System.Drawing.Point(225, 321);
            this.txtcodigoproveedor.Name = "txtcodigoproveedor";
            this.txtcodigoproveedor.Size = new System.Drawing.Size(89, 20);
            this.txtcodigoproveedor.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(318, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "Telefono Proveedor";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.White;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.Black;
            this.BtnActualizar.Location = new System.Drawing.Point(401, 409);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(102, 35);
            this.BtnActualizar.TabIndex = 43;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminarProveedores
            // 
            this.BtnEliminarProveedores.BackColor = System.Drawing.Color.White;
            this.BtnEliminarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarProveedores.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProveedores.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminarProveedores.Location = new System.Drawing.Point(616, 409);
            this.BtnEliminarProveedores.Name = "BtnEliminarProveedores";
            this.BtnEliminarProveedores.Size = new System.Drawing.Size(102, 35);
            this.BtnEliminarProveedores.TabIndex = 40;
            this.BtnEliminarProveedores.Text = "Eliminar";
            this.BtnEliminarProveedores.UseVisualStyleBackColor = false;
            this.BtnEliminarProveedores.Click += new System.EventHandler(this.BtnEliminarProveedores_Click);
            // 
            // dgvproveedor
            // 
            this.dgvproveedor.AllowUserToAddRows = false;
            this.dgvproveedor.AllowUserToDeleteRows = false;
            this.dgvproveedor.AllowUserToOrderColumns = true;
            this.dgvproveedor.AllowUserToResizeColumns = false;
            this.dgvproveedor.AllowUserToResizeRows = false;
            this.dgvproveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproveedor.BackgroundColor = System.Drawing.Color.White;
            this.dgvproveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvproveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvproveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idt_proveedor,
            this.NombreProveedor,
            this.UbicacionProveedor,
            this.TelefonoProveedor,
            this.Correo});
            this.dgvproveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproveedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproveedor.EnableHeadersVisualStyles = false;
            this.dgvproveedor.GridColor = System.Drawing.Color.White;
            this.dgvproveedor.Location = new System.Drawing.Point(66, 117);
            this.dgvproveedor.MultiSelect = false;
            this.dgvproveedor.Name = "dgvproveedor";
            this.dgvproveedor.ReadOnly = true;
            this.dgvproveedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvproveedor.RowHeadersVisible = false;
            this.dgvproveedor.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvproveedor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvproveedor.RowTemplate.Height = 30;
            this.dgvproveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproveedor.Size = new System.Drawing.Size(773, 189);
            this.dgvproveedor.TabIndex = 52;
            this.dgvproveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproveedor_CellClick);
            // 
            // idt_proveedor
            // 
            this.idt_proveedor.DataPropertyName = "idt_proveedor";
            this.idt_proveedor.FillWeight = 76.14214F;
            this.idt_proveedor.HeaderText = "Codigo";
            this.idt_proveedor.Name = "idt_proveedor";
            this.idt_proveedor.ReadOnly = true;
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.DataPropertyName = "NombreProveedor";
            this.NombreProveedor.FillWeight = 111.9289F;
            this.NombreProveedor.HeaderText = "Nombre";
            this.NombreProveedor.Name = "NombreProveedor";
            this.NombreProveedor.ReadOnly = true;
            // 
            // UbicacionProveedor
            // 
            this.UbicacionProveedor.DataPropertyName = "UbicacionProveedor";
            this.UbicacionProveedor.HeaderText = "UbicacionProveedor";
            this.UbicacionProveedor.Name = "UbicacionProveedor";
            this.UbicacionProveedor.ReadOnly = true;
            // 
            // TelefonoProveedor
            // 
            this.TelefonoProveedor.DataPropertyName = "TelefonoProveedor";
            this.TelefonoProveedor.HeaderText = "TelefonoProveedor";
            this.TelefonoProveedor.Name = "TelefonoProveedor";
            this.TelefonoProveedor.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(107)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(930, 489);
            this.Controls.Add(this.dgvproveedor);
            this.Controls.Add(this.mtxtTelefono);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtubicacionproveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnombreproveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblidproveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcodigoproveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEliminarProveedores);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmProveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmProveedor_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button BtnCerrar;
        protected System.Windows.Forms.Button BtnAgregar;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox mtxtTelefono;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtubicacionproveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombreproveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblidproveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcodigoproveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminarProveedores;
        private System.Windows.Forms.DataGridView dgvproveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idt_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn UbicacionProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
    }
}