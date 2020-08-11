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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtcodigoalergia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnombrealergia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcodigoalergia = new System.Windows.Forms.Label();
            this.BtnEliminarAlergia = new System.Windows.Forms.Button();
            this.dgvalergia = new System.Windows.Forms.DataGridView();
            this.IDALERGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalergia)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.White;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCerrar.FlatAppearance.BorderSize = 2;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Black;
            this.BtnCerrar.Location = new System.Drawing.Point(698, 341);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(87, 35);
            this.BtnCerrar.TabIndex = 17;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.White;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAgregar.FlatAppearance.BorderSize = 2;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Location = new System.Drawing.Point(663, 122);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(97, 35);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedicalControl.Properties.Resources.flu;
            this.pictureBox1.Location = new System.Drawing.Point(317, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // txtcodigoalergia
            // 
            this.txtcodigoalergia.Location = new System.Drawing.Point(214, 299);
            this.txtcodigoalergia.Name = "txtcodigoalergia";
            this.txtcodigoalergia.Size = new System.Drawing.Size(121, 20);
            this.txtcodigoalergia.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(663, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtnombrealergia
            // 
            this.txtnombrealergia.Location = new System.Drawing.Point(488, 301);
            this.txtnombrealergia.Name = "txtnombrealergia";
            this.txtnombrealergia.Size = new System.Drawing.Size(121, 20);
            this.txtnombrealergia.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(368, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre Alergia";
            // 
            // lblcodigoalergia
            // 
            this.lblcodigoalergia.AutoSize = true;
            this.lblcodigoalergia.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigoalergia.ForeColor = System.Drawing.Color.White;
            this.lblcodigoalergia.Location = new System.Drawing.Point(94, 300);
            this.lblcodigoalergia.Name = "lblcodigoalergia";
            this.lblcodigoalergia.Size = new System.Drawing.Size(105, 18);
            this.lblcodigoalergia.TabIndex = 20;
            this.lblcodigoalergia.Text = "Codigo Alergia";
            // 
            // BtnEliminarAlergia
            // 
            this.BtnEliminarAlergia.BackColor = System.Drawing.Color.White;
            this.BtnEliminarAlergia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnEliminarAlergia.FlatAppearance.BorderSize = 2;
            this.BtnEliminarAlergia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarAlergia.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarAlergia.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminarAlergia.Location = new System.Drawing.Point(663, 234);
            this.BtnEliminarAlergia.Name = "BtnEliminarAlergia";
            this.BtnEliminarAlergia.Size = new System.Drawing.Size(97, 35);
            this.BtnEliminarAlergia.TabIndex = 19;
            this.BtnEliminarAlergia.Text = "Eliminar";
            this.BtnEliminarAlergia.UseVisualStyleBackColor = false;
            // 
            // dgvalergia
            // 
            this.dgvalergia.AllowUserToAddRows = false;
            this.dgvalergia.AllowUserToDeleteRows = false;
            this.dgvalergia.AllowUserToOrderColumns = true;
            this.dgvalergia.AllowUserToResizeColumns = false;
            this.dgvalergia.AllowUserToResizeRows = false;
            this.dgvalergia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvalergia.BackgroundColor = System.Drawing.Color.White;
            this.dgvalergia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvalergia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvalergia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvalergia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvalergia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvalergia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDALERGIA,
            this.NombreA});
            this.dgvalergia.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvalergia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvalergia.EnableHeadersVisualStyles = false;
            this.dgvalergia.GridColor = System.Drawing.Color.White;
            this.dgvalergia.Location = new System.Drawing.Point(97, 104);
            this.dgvalergia.MultiSelect = false;
            this.dgvalergia.Name = "dgvalergia";
            this.dgvalergia.ReadOnly = true;
            this.dgvalergia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvalergia.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvalergia.RowHeadersVisible = false;
            this.dgvalergia.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvalergia.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvalergia.RowTemplate.Height = 30;
            this.dgvalergia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvalergia.Size = new System.Drawing.Size(512, 189);
            this.dgvalergia.TabIndex = 25;
            this.dgvalergia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvalergia_CellClick);
            // 
            // IDALERGIA
            // 
            this.IDALERGIA.DataPropertyName = "IDALERGIA";
            this.IDALERGIA.FillWeight = 76.14214F;
            this.IDALERGIA.HeaderText = "Codigo";
            this.IDALERGIA.Name = "IDALERGIA";
            this.IDALERGIA.ReadOnly = true;
            // 
            // NombreA
            // 
            this.NombreA.DataPropertyName = "NombreA";
            this.NombreA.FillWeight = 111.9289F;
            this.NombreA.HeaderText = "Nombre";
            this.NombreA.Name = "NombreA";
            this.NombreA.ReadOnly = true;
            // 
            // FrmAlergia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(107)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(823, 388);
            this.Controls.Add(this.dgvalergia);
            this.Controls.Add(this.txtcodigoalergia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnombrealergia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcodigoalergia);
            this.Controls.Add(this.BtnEliminarAlergia);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlergia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAlergia";
            this.Load += new System.EventHandler(this.FrmAlergia_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAlergia_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalergia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button BtnCerrar;
        protected System.Windows.Forms.Button BtnAgregar;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtcodigoalergia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnombrealergia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcodigoalergia;
        private System.Windows.Forms.Button BtnEliminarAlergia;
        private System.Windows.Forms.DataGridView dgvalergia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDALERGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreA;
    }
}