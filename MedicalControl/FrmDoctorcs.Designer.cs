namespace MedicalControl
{
    partial class FrmDoctorcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorcs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtcodigodoctor = new System.Windows.Forms.TextBox();
            this.dgvdoctores = new System.Windows.Forms.DataGridView();
            this.IDDOCTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.Label();
            this.txtexpecialidaddoctor = new System.Windows.Forms.TextBox();
            this.BtnActualizarDoctor = new System.Windows.Forms.Button();
            this.lblnombredoctor = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.BtnEliminarDoctor = new System.Windows.Forms.Button();
            this.txtnombredoctor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctores)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.White;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAgregar.FlatAppearance.BorderSize = 2;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Location = new System.Drawing.Point(627, 80);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(100, 37);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.White;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCerrar.FlatAppearance.BorderSize = 2;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.BtnCerrar.ForeColor = System.Drawing.Color.Black;
            this.BtnCerrar.Location = new System.Drawing.Point(650, 363);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(100, 37);
            this.BtnCerrar.TabIndex = 8;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // txtcodigodoctor
            // 
            this.txtcodigodoctor.Location = new System.Drawing.Point(196, 295);
            this.txtcodigodoctor.Name = "txtcodigodoctor";
            this.txtcodigodoctor.Size = new System.Drawing.Size(121, 20);
            this.txtcodigodoctor.TabIndex = 9;
            // 
            // dgvdoctores
            // 
            this.dgvdoctores.AllowUserToAddRows = false;
            this.dgvdoctores.AllowUserToDeleteRows = false;
            this.dgvdoctores.AllowUserToOrderColumns = true;
            this.dgvdoctores.AllowUserToResizeColumns = false;
            this.dgvdoctores.AllowUserToResizeRows = false;
            this.dgvdoctores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdoctores.BackgroundColor = System.Drawing.Color.White;
            this.dgvdoctores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdoctores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvdoctores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdoctores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdoctores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDOCTOR,
            this.NombreDoctor,
            this.Especialidadd});
            this.dgvdoctores.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdoctores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdoctores.EnableHeadersVisualStyles = false;
            this.dgvdoctores.GridColor = System.Drawing.Color.White;
            this.dgvdoctores.Location = new System.Drawing.Point(82, 80);
            this.dgvdoctores.MultiSelect = false;
            this.dgvdoctores.Name = "dgvdoctores";
            this.dgvdoctores.ReadOnly = true;
            this.dgvdoctores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdoctores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdoctores.RowHeadersVisible = false;
            this.dgvdoctores.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdoctores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdoctores.RowTemplate.Height = 30;
            this.dgvdoctores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdoctores.Size = new System.Drawing.Size(512, 189);
            this.dgvdoctores.TabIndex = 8;
            this.dgvdoctores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdoctores_CellClick);
            // 
            // IDDOCTOR
            // 
            this.IDDOCTOR.DataPropertyName = "IDDOCTOR";
            this.IDDOCTOR.FillWeight = 76.14214F;
            this.IDDOCTOR.HeaderText = "Codigo";
            this.IDDOCTOR.Name = "IDDOCTOR";
            this.IDDOCTOR.ReadOnly = true;
            // 
            // NombreDoctor
            // 
            this.NombreDoctor.DataPropertyName = "NombreDoctor";
            this.NombreDoctor.FillWeight = 111.9289F;
            this.NombreDoctor.HeaderText = "Nombre";
            this.NombreDoctor.Name = "NombreDoctor";
            this.NombreDoctor.ReadOnly = true;
            // 
            // Especialidadd
            // 
            this.Especialidadd.DataPropertyName = "Especialidad";
            this.Especialidadd.FillWeight = 111.9289F;
            this.Especialidadd.HeaderText = "Especialidad";
            this.Especialidadd.Name = "Especialidadd";
            this.Especialidadd.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.AutoSize = true;
            this.Especialidad.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Especialidad.ForeColor = System.Drawing.Color.White;
            this.Especialidad.Location = new System.Drawing.Point(79, 331);
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.Size = new System.Drawing.Size(92, 18);
            this.Especialidad.TabIndex = 7;
            this.Especialidad.Text = "Especialidad";
            // 
            // txtexpecialidaddoctor
            // 
            this.txtexpecialidaddoctor.Location = new System.Drawing.Point(196, 330);
            this.txtexpecialidaddoctor.Name = "txtexpecialidaddoctor";
            this.txtexpecialidaddoctor.Size = new System.Drawing.Size(121, 20);
            this.txtexpecialidaddoctor.TabIndex = 6;
            // 
            // BtnActualizarDoctor
            // 
            this.BtnActualizarDoctor.BackColor = System.Drawing.Color.White;
            this.BtnActualizarDoctor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnActualizarDoctor.FlatAppearance.BorderSize = 2;
            this.BtnActualizarDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarDoctor.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.BtnActualizarDoctor.ForeColor = System.Drawing.Color.Black;
            this.BtnActualizarDoctor.Location = new System.Drawing.Point(627, 131);
            this.BtnActualizarDoctor.Name = "BtnActualizarDoctor";
            this.BtnActualizarDoctor.Size = new System.Drawing.Size(100, 37);
            this.BtnActualizarDoctor.TabIndex = 5;
            this.BtnActualizarDoctor.Text = "Actualizar";
            this.BtnActualizarDoctor.UseVisualStyleBackColor = false;
            this.BtnActualizarDoctor.Click += new System.EventHandler(this.BtnActualizarDoctor_Click);
            // 
            // lblnombredoctor
            // 
            this.lblnombredoctor.AutoSize = true;
            this.lblnombredoctor.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombredoctor.ForeColor = System.Drawing.Color.White;
            this.lblnombredoctor.Location = new System.Drawing.Point(336, 296);
            this.lblnombredoctor.Name = "lblnombredoctor";
            this.lblnombredoctor.Size = new System.Drawing.Size(110, 18);
            this.lblnombredoctor.TabIndex = 4;
            this.lblnombredoctor.Text = "Nombre Doctor";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(79, 296);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(53, 18);
            this.lblid.TabIndex = 3;
            this.lblid.Text = "Codigo";
            // 
            // BtnEliminarDoctor
            // 
            this.BtnEliminarDoctor.BackColor = System.Drawing.Color.White;
            this.BtnEliminarDoctor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnEliminarDoctor.FlatAppearance.BorderSize = 2;
            this.BtnEliminarDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarDoctor.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.BtnEliminarDoctor.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminarDoctor.Location = new System.Drawing.Point(627, 181);
            this.BtnEliminarDoctor.Name = "BtnEliminarDoctor";
            this.BtnEliminarDoctor.Size = new System.Drawing.Size(100, 37);
            this.BtnEliminarDoctor.TabIndex = 2;
            this.BtnEliminarDoctor.Text = "Eliminar";
            this.BtnEliminarDoctor.UseVisualStyleBackColor = false;
            this.BtnEliminarDoctor.Click += new System.EventHandler(this.BtnEliminarDoctor_Click);
            // 
            // txtnombredoctor
            // 
            this.txtnombredoctor.Location = new System.Drawing.Point(453, 295);
            this.txtnombredoctor.Name = "txtnombredoctor";
            this.txtnombredoctor.Size = new System.Drawing.Size(121, 20);
            this.txtnombredoctor.TabIndex = 1;
            // 
            // FrmDoctorcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(107)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(762, 408);
            this.Controls.Add(this.txtcodigodoctor);
            this.Controls.Add(this.dgvdoctores);
            this.Controls.Add(this.Especialidad);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.txtexpecialidaddoctor);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnActualizarDoctor);
            this.Controls.Add(this.lblnombredoctor);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.BtnEliminarDoctor);
            this.Controls.Add(this.txtnombredoctor);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDoctorcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmDoctorcs";
            this.Load += new System.EventHandler(this.FrmDoctorcs_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmDoctorcs_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Button BtnAgregar;
        protected System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.TextBox txtcodigodoctor;
        private System.Windows.Forms.DataGridView dgvdoctores;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDOCTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidadd;
        private System.Windows.Forms.Label Especialidad;
        private System.Windows.Forms.TextBox txtexpecialidaddoctor;
        private System.Windows.Forms.Button BtnActualizarDoctor;
        private System.Windows.Forms.Label lblnombredoctor;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button BtnEliminarDoctor;
        private System.Windows.Forms.TextBox txtnombredoctor;
    }
}