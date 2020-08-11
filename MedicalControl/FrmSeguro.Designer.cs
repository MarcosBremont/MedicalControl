namespace MedicalControl
{
    partial class FrmSeguro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtcodigoseguro = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtnombreseguro = new System.Windows.Forms.TextBox();
            this.lblcodigoseguro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminarSeguros = new System.Windows.Forms.Button();
            this.dgvsegurom = new System.Windows.Forms.DataGridView();
            this.IDSEGURO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreSeguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsegurom)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.White;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCerrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Black;
            this.BtnCerrar.Location = new System.Drawing.Point(666, 346);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(87, 35);
            this.BtnCerrar.TabIndex = 22;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.White;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Location = new System.Drawing.Point(653, 115);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(87, 35);
            this.BtnAgregar.TabIndex = 21;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedicalControl.Properties.Resources.insurance;
            this.pictureBox1.Location = new System.Drawing.Point(318, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // txtcodigoseguro
            // 
            this.txtcodigoseguro.Location = new System.Drawing.Point(219, 311);
            this.txtcodigoseguro.Name = "txtcodigoseguro";
            this.txtcodigoseguro.Size = new System.Drawing.Size(91, 20);
            this.txtcodigoseguro.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(653, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 35);
            this.button3.TabIndex = 28;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtnombreseguro
            // 
            this.txtnombreseguro.Location = new System.Drawing.Point(478, 312);
            this.txtnombreseguro.Name = "txtnombreseguro";
            this.txtnombreseguro.Size = new System.Drawing.Size(91, 20);
            this.txtnombreseguro.TabIndex = 23;
            // 
            // lblcodigoseguro
            // 
            this.lblcodigoseguro.AutoSize = true;
            this.lblcodigoseguro.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigoseguro.ForeColor = System.Drawing.Color.White;
            this.lblcodigoseguro.Location = new System.Drawing.Point(130, 312);
            this.lblcodigoseguro.Name = "lblcodigoseguro";
            this.lblcodigoseguro.Size = new System.Drawing.Size(73, 18);
            this.lblcodigoseguro.TabIndex = 27;
            this.lblcodigoseguro.Text = "N. Seguro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(361, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre Seguro";
            // 
            // BtnEliminarSeguros
            // 
            this.BtnEliminarSeguros.BackColor = System.Drawing.Color.White;
            this.BtnEliminarSeguros.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnEliminarSeguros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarSeguros.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarSeguros.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminarSeguros.Location = new System.Drawing.Point(653, 170);
            this.BtnEliminarSeguros.Name = "BtnEliminarSeguros";
            this.BtnEliminarSeguros.Size = new System.Drawing.Size(87, 35);
            this.BtnEliminarSeguros.TabIndex = 24;
            this.BtnEliminarSeguros.Text = "Eliminar";
            this.BtnEliminarSeguros.UseVisualStyleBackColor = false;
            this.BtnEliminarSeguros.Click += new System.EventHandler(this.BtnEliminarSeguros_Click);
            // 
            // dgvsegurom
            // 
            this.dgvsegurom.AllowUserToAddRows = false;
            this.dgvsegurom.AllowUserToDeleteRows = false;
            this.dgvsegurom.AllowUserToOrderColumns = true;
            this.dgvsegurom.AllowUserToResizeColumns = false;
            this.dgvsegurom.AllowUserToResizeRows = false;
            this.dgvsegurom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsegurom.BackgroundColor = System.Drawing.Color.White;
            this.dgvsegurom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvsegurom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvsegurom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsegurom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvsegurom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsegurom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSEGURO,
            this.NombreSeguro});
            this.dgvsegurom.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsegurom.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvsegurom.EnableHeadersVisualStyles = false;
            this.dgvsegurom.GridColor = System.Drawing.Color.White;
            this.dgvsegurom.Location = new System.Drawing.Point(95, 105);
            this.dgvsegurom.MultiSelect = false;
            this.dgvsegurom.Name = "dgvsegurom";
            this.dgvsegurom.ReadOnly = true;
            this.dgvsegurom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsegurom.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvsegurom.RowHeadersVisible = false;
            this.dgvsegurom.RowHeadersWidth = 10;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvsegurom.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvsegurom.RowTemplate.Height = 30;
            this.dgvsegurom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsegurom.Size = new System.Drawing.Size(522, 189);
            this.dgvsegurom.TabIndex = 30;
            this.dgvsegurom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsegurom_CellClick);
            // 
            // IDSEGURO
            // 
            this.IDSEGURO.DataPropertyName = "IDSEGURO";
            this.IDSEGURO.FillWeight = 76.14214F;
            this.IDSEGURO.HeaderText = "Codigo";
            this.IDSEGURO.Name = "IDSEGURO";
            this.IDSEGURO.ReadOnly = true;
            // 
            // NombreSeguro
            // 
            this.NombreSeguro.DataPropertyName = "NombreSeguro";
            this.NombreSeguro.FillWeight = 111.9289F;
            this.NombreSeguro.HeaderText = "Nombre";
            this.NombreSeguro.Name = "NombreSeguro";
            this.NombreSeguro.ReadOnly = true;
            // 
            // FrmSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(107)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(762, 408);
            this.Controls.Add(this.dgvsegurom);
            this.Controls.Add(this.txtcodigoseguro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtnombreseguro);
            this.Controls.Add(this.lblcodigoseguro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminarSeguros);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSeguro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSeguro";
            this.Load += new System.EventHandler(this.FrmSeguro_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmSeguro_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsegurom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button BtnCerrar;
        protected System.Windows.Forms.Button BtnAgregar;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtcodigoseguro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtnombreseguro;
        private System.Windows.Forms.Label lblcodigoseguro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminarSeguros;
        private System.Windows.Forms.DataGridView dgvsegurom;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSEGURO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSeguro;
    }
}