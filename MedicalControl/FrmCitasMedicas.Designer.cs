﻿namespace MedicalControl
{
    partial class FrmCitasMedicas
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblcedula = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.dthora = new System.Windows.Forms.DateTimePicker();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.cmbnseguro = new System.Windows.Forms.ComboBox();
            this.cmbnalergia = new System.Windows.Forms.ComboBox();
            this.cmbndoctor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombrecompleto = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gbprincipal = new System.Windows.Forms.GroupBox();
            this.dgvcitasmedicas = new System.Windows.Forms.DataGridView();
            this.IDCITAMEDICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORACM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHACM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMENTARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID2SEGUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID2ALERG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID2DOCTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbprincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcitasmedicas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "N. Cita Medica";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lbltelefono.ForeColor = System.Drawing.Color.White;
            this.lbltelefono.Location = new System.Drawing.Point(623, 106);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(62, 16);
            this.lbltelefono.TabIndex = 41;
            this.lbltelefono.Text = "N. Doctor";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lbldireccion.ForeColor = System.Drawing.Color.White;
            this.lbldireccion.Location = new System.Drawing.Point(623, 142);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(65, 16);
            this.lbldireccion.TabIndex = 40;
            this.lbldireccion.Text = "N. Alergia";
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblcedula.ForeColor = System.Drawing.Color.White;
            this.lblcedula.Location = new System.Drawing.Point(397, 142);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(65, 16);
            this.lblcedula.TabIndex = 39;
            this.lblcedula.Text = "N. Seguro";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lbledad.ForeColor = System.Drawing.Color.White;
            this.lbledad.Location = new System.Drawing.Point(146, 177);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(75, 16);
            this.lbledad.TabIndex = 38;
            this.lbledad.Text = "Comentario";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblapellido.ForeColor = System.Drawing.Color.White;
            this.lblapellido.Location = new System.Drawing.Point(397, 106);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(42, 16);
            this.lblapellido.TabIndex = 37;
            this.lblapellido.Text = "Fecha";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(146, 142);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(37, 16);
            this.lblnombre.TabIndex = 36;
            this.lblnombre.Text = "Hora";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(268, 75);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 16);
            this.lblid.TabIndex = 35;
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.White;
            this.btnactualizar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.Black;
            this.btnactualizar.Location = new System.Drawing.Point(517, 36);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(103, 36);
            this.btnactualizar.TabIndex = 34;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(401, 36);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 36);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.BackColor = System.Drawing.Color.White;
            this.btninsertar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.ForeColor = System.Drawing.Color.Black;
            this.btninsertar.Location = new System.Drawing.Point(285, 36);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(103, 36);
            this.btninsertar.TabIndex = 32;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = false;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // txtcomentario
            // 
            this.txtcomentario.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomentario.Location = new System.Drawing.Point(265, 182);
            this.txtcomentario.MaxLength = 300;
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcomentario.Size = new System.Drawing.Size(553, 86);
            this.txtcomentario.TabIndex = 26;
            // 
            // dthora
            // 
            this.dthora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dthora.Location = new System.Drawing.Point(265, 140);
            this.dthora.Name = "dthora";
            this.dthora.Size = new System.Drawing.Size(108, 27);
            this.dthora.TabIndex = 45;
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfecha.Location = new System.Drawing.Point(469, 104);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(121, 27);
            this.dtfecha.TabIndex = 46;
            // 
            // cmbnseguro
            // 
            this.cmbnseguro.FormattingEnabled = true;
            this.cmbnseguro.Location = new System.Drawing.Point(469, 140);
            this.cmbnseguro.Name = "cmbnseguro";
            this.cmbnseguro.Size = new System.Drawing.Size(121, 27);
            this.cmbnseguro.TabIndex = 47;
            // 
            // cmbnalergia
            // 
            this.cmbnalergia.FormattingEnabled = true;
            this.cmbnalergia.Location = new System.Drawing.Point(697, 140);
            this.cmbnalergia.Name = "cmbnalergia";
            this.cmbnalergia.Size = new System.Drawing.Size(121, 27);
            this.cmbnalergia.TabIndex = 48;
            // 
            // cmbndoctor
            // 
            this.cmbndoctor.FormattingEnabled = true;
            this.cmbndoctor.Location = new System.Drawing.Point(697, 104);
            this.cmbndoctor.Name = "cmbndoctor";
            this.cmbndoctor.Size = new System.Drawing.Size(121, 27);
            this.cmbndoctor.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nombre Completo";
            // 
            // txtnombrecompleto
            // 
            this.txtnombrecompleto.Location = new System.Drawing.Point(265, 104);
            this.txtnombrecompleto.MaxLength = 60;
            this.txtnombrecompleto.Name = "txtnombrecompleto";
            this.txtnombrecompleto.Size = new System.Drawing.Size(108, 27);
            this.txtnombrecompleto.TabIndex = 51;
            this.txtnombrecompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombrecompleto_KeyPress);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(626, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 36);
            this.button3.TabIndex = 52;
            this.button3.Text = "Exportar a Excel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gbprincipal
            // 
            this.gbprincipal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbprincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(107)))), ((int)(((byte)(167)))));
            this.gbprincipal.Controls.Add(this.txtcomentario);
            this.gbprincipal.Controls.Add(this.button3);
            this.gbprincipal.Controls.Add(this.btnactualizar);
            this.gbprincipal.Controls.Add(this.lblid);
            this.gbprincipal.Controls.Add(this.btnEliminar);
            this.gbprincipal.Controls.Add(this.txtnombrecompleto);
            this.gbprincipal.Controls.Add(this.btninsertar);
            this.gbprincipal.Controls.Add(this.lblnombre);
            this.gbprincipal.Controls.Add(this.label2);
            this.gbprincipal.Controls.Add(this.lblapellido);
            this.gbprincipal.Controls.Add(this.cmbndoctor);
            this.gbprincipal.Controls.Add(this.lbledad);
            this.gbprincipal.Controls.Add(this.cmbnalergia);
            this.gbprincipal.Controls.Add(this.lblcedula);
            this.gbprincipal.Controls.Add(this.cmbnseguro);
            this.gbprincipal.Controls.Add(this.lbldireccion);
            this.gbprincipal.Controls.Add(this.dtfecha);
            this.gbprincipal.Controls.Add(this.lbltelefono);
            this.gbprincipal.Controls.Add(this.dthora);
            this.gbprincipal.Controls.Add(this.label1);
            this.gbprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbprincipal.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbprincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbprincipal.Location = new System.Drawing.Point(147, 224);
            this.gbprincipal.Name = "gbprincipal";
            this.gbprincipal.Size = new System.Drawing.Size(947, 280);
            this.gbprincipal.TabIndex = 76;
            this.gbprincipal.TabStop = false;
            this.gbprincipal.Text = "Citas Medicas";
            // 
            // dgvcitasmedicas
            // 
            this.dgvcitasmedicas.AllowUserToAddRows = false;
            this.dgvcitasmedicas.AllowUserToDeleteRows = false;
            this.dgvcitasmedicas.AllowUserToOrderColumns = true;
            this.dgvcitasmedicas.AllowUserToResizeColumns = false;
            this.dgvcitasmedicas.AllowUserToResizeRows = false;
            this.dgvcitasmedicas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcitasmedicas.BackgroundColor = System.Drawing.Color.White;
            this.dgvcitasmedicas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvcitasmedicas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvcitasmedicas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcitasmedicas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcitasmedicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcitasmedicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCITAMEDICA,
            this.HORACM,
            this.FECHACM,
            this.COMENTARIO,
            this.ID2SEGUR,
            this.ID2ALERG,
            this.ID2DOCTOR,
            this.NombreCompleto});
            this.dgvcitasmedicas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcitasmedicas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcitasmedicas.EnableHeadersVisualStyles = false;
            this.dgvcitasmedicas.GridColor = System.Drawing.Color.White;
            this.dgvcitasmedicas.Location = new System.Drawing.Point(65, 12);
            this.dgvcitasmedicas.MultiSelect = false;
            this.dgvcitasmedicas.Name = "dgvcitasmedicas";
            this.dgvcitasmedicas.ReadOnly = true;
            this.dgvcitasmedicas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcitasmedicas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcitasmedicas.RowHeadersVisible = false;
            this.dgvcitasmedicas.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvcitasmedicas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvcitasmedicas.RowTemplate.Height = 30;
            this.dgvcitasmedicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcitasmedicas.Size = new System.Drawing.Size(1080, 330);
            this.dgvcitasmedicas.TabIndex = 77;
            this.dgvcitasmedicas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcitasmedicas_CellClick);
            // 
            // IDCITAMEDICA
            // 
            this.IDCITAMEDICA.DataPropertyName = "IDCITAMEDICA";
            this.IDCITAMEDICA.FillWeight = 76.14214F;
            this.IDCITAMEDICA.HeaderText = "Codigo";
            this.IDCITAMEDICA.Name = "IDCITAMEDICA";
            this.IDCITAMEDICA.ReadOnly = true;
            // 
            // HORACM
            // 
            this.HORACM.DataPropertyName = "HORACM";
            this.HORACM.FillWeight = 111.9289F;
            this.HORACM.HeaderText = "Hora Cita";
            this.HORACM.Name = "HORACM";
            this.HORACM.ReadOnly = true;
            // 
            // FECHACM
            // 
            this.FECHACM.DataPropertyName = "FECHACM";
            this.FECHACM.HeaderText = "Fecha Cita";
            this.FECHACM.Name = "FECHACM";
            this.FECHACM.ReadOnly = true;
            // 
            // COMENTARIO
            // 
            this.COMENTARIO.DataPropertyName = "COMENTARIO";
            this.COMENTARIO.HeaderText = "Comentario";
            this.COMENTARIO.Name = "COMENTARIO";
            this.COMENTARIO.ReadOnly = true;
            // 
            // ID2SEGUR
            // 
            this.ID2SEGUR.DataPropertyName = "ID2SEGUR";
            this.ID2SEGUR.HeaderText = "Codigo Seguro";
            this.ID2SEGUR.Name = "ID2SEGUR";
            this.ID2SEGUR.ReadOnly = true;
            // 
            // ID2ALERG
            // 
            this.ID2ALERG.DataPropertyName = "ID2ALERG";
            this.ID2ALERG.HeaderText = "Codigo Alergia";
            this.ID2ALERG.Name = "ID2ALERG";
            this.ID2ALERG.ReadOnly = true;
            // 
            // ID2DOCTOR
            // 
            this.ID2DOCTOR.DataPropertyName = "ID2DOCTOR";
            this.ID2DOCTOR.HeaderText = "Codigo Doctor";
            this.ID2DOCTOR.Name = "ID2DOCTOR";
            this.ID2DOCTOR.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // FrmCitasMedicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1258, 539);
            this.Controls.Add(this.dgvcitasmedicas);
            this.Controls.Add(this.gbprincipal);
            this.Name = "FrmCitasMedicas";
            this.Text = "Citas Medicas";
            this.Load += new System.EventHandler(this.FrmCitasMedicas_Load);
            this.gbprincipal.ResumeLayout(false);
            this.gbprincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcitasmedicas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.DateTimePicker dthora;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.ComboBox cmbnseguro;
        private System.Windows.Forms.ComboBox cmbnalergia;
        private System.Windows.Forms.ComboBox cmbndoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gbprincipal;
        private System.Windows.Forms.DataGridView dgvcitasmedicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCITAMEDICA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORACM;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHACM;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMENTARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2SEGUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2ALERG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2DOCTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
    }
}