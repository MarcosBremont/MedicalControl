﻿namespace MedicalControl
{
    partial class FrmInventario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idt_inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnombremedicamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbproveedor = new System.Windows.Forms.ComboBox();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.lblidmedicamento = new System.Windows.Forms.Label();
            this.lblcedula = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.txtdescripcionmedicamento = new System.Windows.Forms.TextBox();
            this.txtcantidadmedicamento = new System.Windows.Forms.TextBox();
            this.btnOtro = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
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
            this.idt_inventario,
            this.NombreMedicamento,
            this.CantidadMedicamento,
            this.Proveedor,
            this.Descripcion,
            this.Fecha});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(130, 44);
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
            this.dataGridView1.Size = new System.Drawing.Size(947, 267);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idt_inventario
            // 
            this.idt_inventario.DataPropertyName = "idt_inventario";
            this.idt_inventario.HeaderText = "N. Medicamento";
            this.idt_inventario.Name = "idt_inventario";
            this.idt_inventario.ReadOnly = true;
            this.idt_inventario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idt_inventario.Width = 110;
            // 
            // NombreMedicamento
            // 
            this.NombreMedicamento.DataPropertyName = "NombreMedicamento";
            this.NombreMedicamento.HeaderText = "Nombre Medicamento";
            this.NombreMedicamento.Name = "NombreMedicamento";
            this.NombreMedicamento.ReadOnly = true;
            this.NombreMedicamento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreMedicamento.Width = 200;
            // 
            // CantidadMedicamento
            // 
            this.CantidadMedicamento.DataPropertyName = "CantidadMedicamento";
            this.CantidadMedicamento.HeaderText = "Cantidad Medicamento";
            this.CantidadMedicamento.Name = "CantidadMedicamento";
            this.CantidadMedicamento.ReadOnly = true;
            this.CantidadMedicamento.Width = 200;
            // 
            // Proveedor
            // 
            this.Proveedor.DataPropertyName = "Proveedor";
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Width = 120;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // txtnombremedicamento
            // 
            this.txtnombremedicamento.Location = new System.Drawing.Point(458, 399);
            this.txtnombremedicamento.MaxLength = 60;
            this.txtnombremedicamento.Name = "txtnombremedicamento";
            this.txtnombremedicamento.Size = new System.Drawing.Size(108, 20);
            this.txtnombremedicamento.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(318, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Nombre Medicamento";
            // 
            // cbproveedor
            // 
            this.cbproveedor.FormattingEnabled = true;
            this.cbproveedor.Location = new System.Drawing.Point(742, 433);
            this.cbproveedor.Name = "cbproveedor";
            this.cbproveedor.Size = new System.Drawing.Size(121, 21);
            this.cbproveedor.TabIndex = 66;
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfecha.Location = new System.Drawing.Point(742, 397);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(121, 20);
            this.dtfecha.TabIndex = 65;
            // 
            // lblidmedicamento
            // 
            this.lblidmedicamento.AutoSize = true;
            this.lblidmedicamento.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblidmedicamento.ForeColor = System.Drawing.Color.White;
            this.lblidmedicamento.Location = new System.Drawing.Point(318, 371);
            this.lblidmedicamento.Name = "lblidmedicamento";
            this.lblidmedicamento.Size = new System.Drawing.Size(99, 16);
            this.lblidmedicamento.TabIndex = 63;
            this.lblidmedicamento.Text = "N. Medicamento";
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblcedula.ForeColor = System.Drawing.Color.White;
            this.lblcedula.Location = new System.Drawing.Point(669, 435);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(70, 16);
            this.lblcedula.TabIndex = 60;
            this.lblcedula.Text = "Proveedor";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lbledad.ForeColor = System.Drawing.Color.White;
            this.lbledad.Location = new System.Drawing.Point(318, 471);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(76, 16);
            this.lbledad.TabIndex = 59;
            this.lbledad.Text = "Descripcion";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblapellido.ForeColor = System.Drawing.Color.White;
            this.lblapellido.Location = new System.Drawing.Point(669, 399);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(42, 16);
            this.lblapellido.TabIndex = 58;
            this.lblapellido.Text = "Fecha";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(318, 438);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(137, 16);
            this.lblnombre.TabIndex = 57;
            this.lblnombre.Text = "Cantidad Medicamento";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(404, 371);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 16);
            this.lblid.TabIndex = 56;
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnactualizar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnactualizar.Location = new System.Drawing.Point(654, 317);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(103, 35);
            this.btnactualizar.TabIndex = 55;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(538, 317);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 35);
            this.btnEliminar.TabIndex = 54;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btninsertar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btninsertar.Location = new System.Drawing.Point(422, 317);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(103, 35);
            this.btninsertar.TabIndex = 53;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = false;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // txtdescripcionmedicamento
            // 
            this.txtdescripcionmedicamento.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcionmedicamento.Location = new System.Drawing.Point(442, 476);
            this.txtdescripcionmedicamento.MaxLength = 30;
            this.txtdescripcionmedicamento.Multiline = true;
            this.txtdescripcionmedicamento.Name = "txtdescripcionmedicamento";
            this.txtdescripcionmedicamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdescripcionmedicamento.Size = new System.Drawing.Size(421, 58);
            this.txtdescripcionmedicamento.TabIndex = 52;
            // 
            // txtcantidadmedicamento
            // 
            this.txtcantidadmedicamento.Location = new System.Drawing.Point(458, 435);
            this.txtcantidadmedicamento.MaxLength = 60;
            this.txtcantidadmedicamento.Name = "txtcantidadmedicamento";
            this.txtcantidadmedicamento.Size = new System.Drawing.Size(108, 20);
            this.txtcantidadmedicamento.TabIndex = 71;
            // 
            // btnOtro
            // 
            this.btnOtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnOtro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOtro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOtro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnOtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtro.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOtro.Location = new System.Drawing.Point(869, 427);
            this.btnOtro.Name = "btnOtro";
            this.btnOtro.Size = new System.Drawing.Size(79, 28);
            this.btnOtro.TabIndex = 72;
            this.btnOtro.Text = "Otro";
            this.btnOtro.UseVisualStyleBackColor = false;
            this.btnOtro.Click += new System.EventHandler(this.btnOtro_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(264, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 35);
            this.button3.TabIndex = 73;
            this.button3.Text = "Exportar a Excel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1339, 557);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnOtro);
            this.Controls.Add(this.txtcantidadmedicamento);
            this.Controls.Add(this.txtnombremedicamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbproveedor);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.lblidmedicamento);
            this.Controls.Add(this.lblcedula);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txtdescripcionmedicamento);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtnombremedicamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbproveedor;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Label lblidmedicamento;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.TextBox txtdescripcionmedicamento;
        private System.Windows.Forms.TextBox txtcantidadmedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idt_inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button btnOtro;
        private System.Windows.Forms.Button button3;
    }
}