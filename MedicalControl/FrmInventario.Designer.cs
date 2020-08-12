namespace MedicalControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.button1 = new System.Windows.Forms.Button();
            this.gbprincipal = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dgvinventario = new System.Windows.Forms.DataGridView();
            this.idt_inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbprincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinventario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombremedicamento
            // 
            this.txtnombremedicamento.Location = new System.Drawing.Point(283, 106);
            this.txtnombremedicamento.MaxLength = 60;
            this.txtnombremedicamento.Name = "txtnombremedicamento";
            this.txtnombremedicamento.Size = new System.Drawing.Size(153, 27);
            this.txtnombremedicamento.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(148, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Nombre Medicamento";
            // 
            // cbproveedor
            // 
            this.cbproveedor.FormattingEnabled = true;
            this.cbproveedor.Location = new System.Drawing.Point(551, 145);
            this.cbproveedor.Name = "cbproveedor";
            this.cbproveedor.Size = new System.Drawing.Size(173, 27);
            this.cbproveedor.TabIndex = 66;
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfecha.Location = new System.Drawing.Point(603, 104);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(121, 27);
            this.dtfecha.TabIndex = 65;
            // 
            // lblidmedicamento
            // 
            this.lblidmedicamento.AutoSize = true;
            this.lblidmedicamento.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblidmedicamento.ForeColor = System.Drawing.Color.White;
            this.lblidmedicamento.Location = new System.Drawing.Point(150, 71);
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
            this.lblcedula.Location = new System.Drawing.Point(478, 150);
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
            this.lbledad.Location = new System.Drawing.Point(148, 178);
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
            this.lblapellido.Location = new System.Drawing.Point(532, 109);
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
            this.lblnombre.Location = new System.Drawing.Point(148, 145);
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
            this.lblid.Location = new System.Drawing.Point(323, 71);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 16);
            this.lblid.TabIndex = 56;
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.White;
            this.btnactualizar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.Black;
            this.btnactualizar.Location = new System.Drawing.Point(535, 21);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(103, 35);
            this.btnactualizar.TabIndex = 55;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(419, 21);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 35);
            this.btnEliminar.TabIndex = 54;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.BackColor = System.Drawing.Color.White;
            this.btninsertar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.ForeColor = System.Drawing.Color.Black;
            this.btninsertar.Location = new System.Drawing.Point(303, 21);
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
            this.txtdescripcionmedicamento.Location = new System.Drawing.Point(283, 183);
            this.txtdescripcionmedicamento.MaxLength = 300;
            this.txtdescripcionmedicamento.Multiline = true;
            this.txtdescripcionmedicamento.Name = "txtdescripcionmedicamento";
            this.txtdescripcionmedicamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdescripcionmedicamento.Size = new System.Drawing.Size(441, 94);
            this.txtdescripcionmedicamento.TabIndex = 52;
            // 
            // txtcantidadmedicamento
            // 
            this.txtcantidadmedicamento.Location = new System.Drawing.Point(283, 142);
            this.txtcantidadmedicamento.MaxLength = 60;
            this.txtcantidadmedicamento.Name = "txtcantidadmedicamento";
            this.txtcantidadmedicamento.Size = new System.Drawing.Size(153, 27);
            this.txtcantidadmedicamento.TabIndex = 71;
            this.txtcantidadmedicamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidadmedicamento_KeyPress);
            // 
            // btnOtro
            // 
            this.btnOtro.BackColor = System.Drawing.Color.White;
            this.btnOtro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOtro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOtro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnOtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtro.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtro.ForeColor = System.Drawing.Color.Black;
            this.btnOtro.Location = new System.Drawing.Point(730, 145);
            this.btnOtro.Name = "btnOtro";
            this.btnOtro.Size = new System.Drawing.Size(39, 28);
            this.btnOtro.TabIndex = 72;
            this.btnOtro.Text = "...";
            this.btnOtro.UseVisualStyleBackColor = false;
            this.btnOtro.Click += new System.EventHandler(this.btnOtro_Click);
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
            this.button3.Location = new System.Drawing.Point(656, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 35);
            this.button3.TabIndex = 73;
            this.button3.Text = "Exportar a Excel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(656, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 35);
            this.button1.TabIndex = 74;
            this.button1.Text = "Importar de Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbprincipal
            // 
            this.gbprincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(107)))), ((int)(((byte)(167)))));
            this.gbprincipal.Controls.Add(this.button1);
            this.gbprincipal.Controls.Add(this.lblbuscar);
            this.gbprincipal.Controls.Add(this.button3);
            this.gbprincipal.Controls.Add(this.txtbuscar);
            this.gbprincipal.Controls.Add(this.btnOtro);
            this.gbprincipal.Controls.Add(this.label8);
            this.gbprincipal.Controls.Add(this.txtcantidadmedicamento);
            this.gbprincipal.Controls.Add(this.TxtCantidad);
            this.gbprincipal.Controls.Add(this.txtnombremedicamento);
            this.gbprincipal.Controls.Add(this.txtdescripcionmedicamento);
            this.gbprincipal.Controls.Add(this.label2);
            this.gbprincipal.Controls.Add(this.btninsertar);
            this.gbprincipal.Controls.Add(this.cbproveedor);
            this.gbprincipal.Controls.Add(this.btnEliminar);
            this.gbprincipal.Controls.Add(this.dtfecha);
            this.gbprincipal.Controls.Add(this.btnactualizar);
            this.gbprincipal.Controls.Add(this.lblidmedicamento);
            this.gbprincipal.Controls.Add(this.lblid);
            this.gbprincipal.Controls.Add(this.lblcedula);
            this.gbprincipal.Controls.Add(this.lblnombre);
            this.gbprincipal.Controls.Add(this.lbledad);
            this.gbprincipal.Controls.Add(this.lblapellido);
            this.gbprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbprincipal.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbprincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbprincipal.Location = new System.Drawing.Point(91, 337);
            this.gbprincipal.Name = "gbprincipal";
            this.gbprincipal.Size = new System.Drawing.Size(947, 292);
            this.gbprincipal.TabIndex = 75;
            this.gbprincipal.TabStop = false;
            this.gbprincipal.Text = "Inventario";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(191, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Cantidad";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCantidad.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.ForeColor = System.Drawing.Color.DarkRed;
            this.TxtCantidad.Location = new System.Drawing.Point(255, 26);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.ReadOnly = true;
            this.TxtCantidad.Size = new System.Drawing.Size(45, 23);
            this.TxtCantidad.TabIndex = 46;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblbuscar.ForeColor = System.Drawing.Color.Black;
            this.lblbuscar.Location = new System.Drawing.Point(15, 30);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(49, 16);
            this.lblbuscar.TabIndex = 49;
            this.lblbuscar.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(70, 26);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 27);
            this.txtbuscar.TabIndex = 48;
            this.txtbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscar_KeyUp);
            // 
            // dgvinventario
            // 
            this.dgvinventario.AllowUserToAddRows = false;
            this.dgvinventario.AllowUserToDeleteRows = false;
            this.dgvinventario.AllowUserToOrderColumns = true;
            this.dgvinventario.AllowUserToResizeColumns = false;
            this.dgvinventario.AllowUserToResizeRows = false;
            this.dgvinventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvinventario.BackgroundColor = System.Drawing.Color.White;
            this.dgvinventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvinventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvinventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvinventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvinventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idt_inventario,
            this.NombreMedicamento,
            this.CantidadMedicamento,
            this.Proveedor,
            this.Descripcion,
            this.Fecha});
            this.dgvinventario.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvinventario.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvinventario.EnableHeadersVisualStyles = false;
            this.dgvinventario.GridColor = System.Drawing.Color.White;
            this.dgvinventario.Location = new System.Drawing.Point(39, 40);
            this.dgvinventario.MultiSelect = false;
            this.dgvinventario.Name = "dgvinventario";
            this.dgvinventario.ReadOnly = true;
            this.dgvinventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvinventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvinventario.RowHeadersVisible = false;
            this.dgvinventario.RowHeadersWidth = 10;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvinventario.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvinventario.RowTemplate.Height = 30;
            this.dgvinventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvinventario.Size = new System.Drawing.Size(1038, 291);
            this.dgvinventario.TabIndex = 78;
            this.dgvinventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinventario_CellClick);
            // 
            // idt_inventario
            // 
            this.idt_inventario.DataPropertyName = "idt_inventario";
            this.idt_inventario.FillWeight = 76.14214F;
            this.idt_inventario.HeaderText = "Codigo";
            this.idt_inventario.Name = "idt_inventario";
            this.idt_inventario.ReadOnly = true;
            // 
            // NombreMedicamento
            // 
            this.NombreMedicamento.DataPropertyName = "NombreMedicamento";
            this.NombreMedicamento.FillWeight = 111.9289F;
            this.NombreMedicamento.HeaderText = "Medicamento";
            this.NombreMedicamento.Name = "NombreMedicamento";
            this.NombreMedicamento.ReadOnly = true;
            // 
            // CantidadMedicamento
            // 
            this.CantidadMedicamento.DataPropertyName = "CantidadMedicamento";
            this.CantidadMedicamento.HeaderText = "Cantidad";
            this.CantidadMedicamento.Name = "CantidadMedicamento";
            this.CantidadMedicamento.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.Proveedor.DataPropertyName = "Proveedor";
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1339, 621);
            this.Controls.Add(this.dgvinventario);
            this.Controls.Add(this.gbprincipal);
            this.Name = "FrmInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            this.gbprincipal.ResumeLayout(false);
            this.gbprincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button btnOtro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbprincipal;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.DataGridView dgvinventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idt_inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}