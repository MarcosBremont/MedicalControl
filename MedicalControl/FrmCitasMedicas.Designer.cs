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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dthora = new System.Windows.Forms.DateTimePicker();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.cmbnseguro = new System.Windows.Forms.ComboBox();
            this.cmbnalergia = new System.Windows.Forms.ComboBox();
            this.cmbndoctor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombrecompleto = new System.Windows.Forms.TextBox();
            this.IDCitaMedica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horacm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechacm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID2SEGUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id2alerg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id2doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(339, 339);
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
            this.lbltelefono.Location = new System.Drawing.Point(816, 370);
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
            this.lbldireccion.Location = new System.Drawing.Point(816, 406);
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
            this.lblcedula.Location = new System.Drawing.Point(590, 406);
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
            this.lbledad.Location = new System.Drawing.Point(339, 441);
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
            this.lblapellido.Location = new System.Drawing.Point(590, 370);
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
            this.lblnombre.Location = new System.Drawing.Point(339, 406);
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
            this.lblid.Location = new System.Drawing.Point(425, 339);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 16);
            this.lblid.TabIndex = 35;
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnactualizar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnactualizar.Location = new System.Drawing.Point(728, 285);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(103, 35);
            this.btnactualizar.TabIndex = 34;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(612, 285);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 35);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btninsertar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btninsertar.Location = new System.Drawing.Point(496, 285);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(103, 35);
            this.btninsertar.TabIndex = 32;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = false;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // txtcomentario
            // 
            this.txtcomentario.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomentario.Location = new System.Drawing.Point(458, 446);
            this.txtcomentario.MaxLength = 30;
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcomentario.Size = new System.Drawing.Size(553, 58);
            this.txtcomentario.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCitaMedica,
            this.Horacm,
            this.Fechacm,
            this.Comentario,
            this.ID2SEGUR,
            this.id2alerg,
            this.id2doctor,
            this.NombreCompleto});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(111, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 267);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dthora
            // 
            this.dthora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dthora.Location = new System.Drawing.Point(458, 404);
            this.dthora.Name = "dthora";
            this.dthora.Size = new System.Drawing.Size(108, 20);
            this.dthora.TabIndex = 45;
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfecha.Location = new System.Drawing.Point(662, 368);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(121, 20);
            this.dtfecha.TabIndex = 46;
            // 
            // cmbnseguro
            // 
            this.cmbnseguro.FormattingEnabled = true;
            this.cmbnseguro.Location = new System.Drawing.Point(662, 404);
            this.cmbnseguro.Name = "cmbnseguro";
            this.cmbnseguro.Size = new System.Drawing.Size(121, 21);
            this.cmbnseguro.TabIndex = 47;
            // 
            // cmbnalergia
            // 
            this.cmbnalergia.FormattingEnabled = true;
            this.cmbnalergia.Location = new System.Drawing.Point(890, 404);
            this.cmbnalergia.Name = "cmbnalergia";
            this.cmbnalergia.Size = new System.Drawing.Size(121, 21);
            this.cmbnalergia.TabIndex = 48;
            // 
            // cmbndoctor
            // 
            this.cmbndoctor.FormattingEnabled = true;
            this.cmbndoctor.Location = new System.Drawing.Point(890, 368);
            this.cmbndoctor.Name = "cmbndoctor";
            this.cmbndoctor.Size = new System.Drawing.Size(121, 21);
            this.cmbndoctor.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(339, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nombre Completo";
            // 
            // txtnombrecompleto
            // 
            this.txtnombrecompleto.Location = new System.Drawing.Point(458, 368);
            this.txtnombrecompleto.MaxLength = 60;
            this.txtnombrecompleto.Name = "txtnombrecompleto";
            this.txtnombrecompleto.Size = new System.Drawing.Size(108, 20);
            this.txtnombrecompleto.TabIndex = 51;
            // 
            // IDCitaMedica
            // 
            this.IDCitaMedica.DataPropertyName = "IDCitaMedica";
            this.IDCitaMedica.HeaderText = "N. Cita Medica";
            this.IDCitaMedica.Name = "IDCitaMedica";
            this.IDCitaMedica.ReadOnly = true;
            // 
            // Horacm
            // 
            this.Horacm.DataPropertyName = "Horacm";
            this.Horacm.HeaderText = "Hora Cita";
            this.Horacm.Name = "Horacm";
            this.Horacm.ReadOnly = true;
            this.Horacm.Width = 200;
            // 
            // Fechacm
            // 
            this.Fechacm.DataPropertyName = "Fechacm";
            this.Fechacm.HeaderText = "Fecha Cita";
            this.Fechacm.Name = "Fechacm";
            this.Fechacm.ReadOnly = true;
            this.Fechacm.Width = 200;
            // 
            // Comentario
            // 
            this.Comentario.DataPropertyName = "Comentario";
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            this.Comentario.Width = 200;
            // 
            // ID2SEGUR
            // 
            this.ID2SEGUR.DataPropertyName = "ID2SEGUR";
            this.ID2SEGUR.HeaderText = "N. Seguro Medico";
            this.ID2SEGUR.Name = "ID2SEGUR";
            this.ID2SEGUR.ReadOnly = true;
            // 
            // id2alerg
            // 
            this.id2alerg.DataPropertyName = "id2alerg";
            this.id2alerg.HeaderText = "N. Alergia";
            this.id2alerg.Name = "id2alerg";
            this.id2alerg.ReadOnly = true;
            // 
            // id2doctor
            // 
            this.id2doctor.DataPropertyName = "id2doctor";
            this.id2doctor.HeaderText = "N. Doctor";
            this.id2doctor.Name = "id2doctor";
            this.id2doctor.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.FillWeight = 200F;
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 200;
            // 
            // FrmCitasMedicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1258, 539);
            this.Controls.Add(this.txtnombrecompleto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbndoctor);
            this.Controls.Add(this.cmbnalergia);
            this.Controls.Add(this.cmbnseguro);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.dthora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblcedula);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCitasMedicas";
            this.Text = "Citas Medicas";
            this.Load += new System.EventHandler(this.FrmCitasMedicas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dthora;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.ComboBox cmbnseguro;
        private System.Windows.Forms.ComboBox cmbnalergia;
        private System.Windows.Forms.ComboBox cmbndoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCitaMedica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horacm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechacm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2SEGUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2alerg;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
    }
}