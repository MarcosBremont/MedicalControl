namespace MedicalControl
{
    partial class FrmPPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalControlDataSet = new MedicalControl.MedicalControlDataSet();
            this.pacienteTableAdapter = new MedicalControl.MedicalControlDataSetTableAdapters.PacienteTableAdapter();
            this.gbprincipal = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnombrep = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.txtapellidop = new System.Windows.Forms.TextBox();
            this.txtedadp = new System.Windows.Forms.TextBox();
            this.btnOtro = new System.Windows.Forms.Button();
            this.txtdireccionp = new System.Windows.Forms.TextBox();
            this.mtxtTelefono2 = new System.Windows.Forms.MaskedTextBox();
            this.btninsertar = new System.Windows.Forms.Button();
            this.mtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.mtxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.lblapellido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.cmbSeguro = new System.Windows.Forms.ComboBox();
            this.lblcedula = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.cmbAlergia = new System.Windows.Forms.ComboBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltelefonoep = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvprincipal = new System.Windows.Forms.DataGridView();
            this.IDPACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCIONP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONOP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTALER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTSEGURO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTDOCTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalControlDataSet)).BeginInit();
            this.gbprincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.medicalControlDataSet;
            // 
            // medicalControlDataSet
            // 
            this.medicalControlDataSet.DataSetName = "MedicalControlDataSet";
            this.medicalControlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // gbprincipal
            // 
            this.gbprincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(107)))), ((int)(((byte)(167)))));
            this.gbprincipal.Controls.Add(this.button3);
            this.gbprincipal.Controls.Add(this.lblid);
            this.gbprincipal.Controls.Add(this.lblbuscar);
            this.gbprincipal.Controls.Add(this.button2);
            this.gbprincipal.Controls.Add(this.txtbuscar);
            this.gbprincipal.Controls.Add(this.button1);
            this.gbprincipal.Controls.Add(this.label8);
            this.gbprincipal.Controls.Add(this.txtnombrep);
            this.gbprincipal.Controls.Add(this.TxtCantidad);
            this.gbprincipal.Controls.Add(this.txtapellidop);
            this.gbprincipal.Controls.Add(this.txtedadp);
            this.gbprincipal.Controls.Add(this.btnOtro);
            this.gbprincipal.Controls.Add(this.txtdireccionp);
            this.gbprincipal.Controls.Add(this.mtxtTelefono2);
            this.gbprincipal.Controls.Add(this.btninsertar);
            this.gbprincipal.Controls.Add(this.mtxtTelefono);
            this.gbprincipal.Controls.Add(this.btnEliminar);
            this.gbprincipal.Controls.Add(this.mtxtCedula);
            this.gbprincipal.Controls.Add(this.btnactualizar);
            this.gbprincipal.Controls.Add(this.label6);
            this.gbprincipal.Controls.Add(this.lblnombre);
            this.gbprincipal.Controls.Add(this.cmbDoctor);
            this.gbprincipal.Controls.Add(this.lblapellido);
            this.gbprincipal.Controls.Add(this.label5);
            this.gbprincipal.Controls.Add(this.lbledad);
            this.gbprincipal.Controls.Add(this.cmbSeguro);
            this.gbprincipal.Controls.Add(this.lblcedula);
            this.gbprincipal.Controls.Add(this.label4);
            this.gbprincipal.Controls.Add(this.lbldireccion);
            this.gbprincipal.Controls.Add(this.cmbAlergia);
            this.gbprincipal.Controls.Add(this.lbltelefono);
            this.gbprincipal.Controls.Add(this.label3);
            this.gbprincipal.Controls.Add(this.lbltelefonoep);
            this.gbprincipal.Controls.Add(this.cmbSexo);
            this.gbprincipal.Controls.Add(this.label1);
            this.gbprincipal.Controls.Add(this.dateTimePicker1);
            this.gbprincipal.Controls.Add(this.label2);
            this.gbprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbprincipal.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbprincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbprincipal.Location = new System.Drawing.Point(12, 355);
            this.gbprincipal.Name = "gbprincipal";
            this.gbprincipal.Size = new System.Drawing.Size(1069, 295);
            this.gbprincipal.TabIndex = 50;
            this.gbprincipal.TabStop = false;
            this.gbprincipal.Text = "Paciente";
            this.gbprincipal.Enter += new System.EventHandler(this.gbprincipal_Enter);
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
            this.button3.Location = new System.Drawing.Point(45, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 35);
            this.button3.TabIndex = 68;
            this.button3.Text = "Exportar a Excel";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(364, 53);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 16);
            this.lblid.TabIndex = 63;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblbuscar.ForeColor = System.Drawing.Color.Black;
            this.lblbuscar.Location = new System.Drawing.Point(42, 23);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(49, 16);
            this.lblbuscar.TabIndex = 86;
            this.lblbuscar.Text = "Buscar";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(854, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 27);
            this.button2.TabIndex = 82;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(98, 17);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 27);
            this.txtbuscar.TabIndex = 85;
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
            this.button1.Location = new System.Drawing.Point(449, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 27);
            this.button1.TabIndex = 81;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(284, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 84;
            this.label8.Text = "Cantidad";
            // 
            // txtnombrep
            // 
            this.txtnombrep.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrep.Location = new System.Drawing.Point(361, 78);
            this.txtnombrep.MaxLength = 30;
            this.txtnombrep.Name = "txtnombrep";
            this.txtnombrep.Size = new System.Drawing.Size(83, 23);
            this.txtnombrep.TabIndex = 50;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCantidad.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.ForeColor = System.Drawing.Color.DarkRed;
            this.TxtCantidad.Location = new System.Drawing.Point(348, 20);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.ReadOnly = true;
            this.TxtCantidad.Size = new System.Drawing.Size(45, 23);
            this.TxtCantidad.TabIndex = 83;
            // 
            // txtapellidop
            // 
            this.txtapellidop.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidop.Location = new System.Drawing.Point(361, 111);
            this.txtapellidop.MaxLength = 30;
            this.txtapellidop.Name = "txtapellidop";
            this.txtapellidop.Size = new System.Drawing.Size(83, 23);
            this.txtapellidop.TabIndex = 51;
            // 
            // txtedadp
            // 
            this.txtedadp.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtedadp.Location = new System.Drawing.Point(556, 57);
            this.txtedadp.MaxLength = 3;
            this.txtedadp.Name = "txtedadp";
            this.txtedadp.Size = new System.Drawing.Size(48, 23);
            this.txtedadp.TabIndex = 53;
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
            this.btnOtro.Location = new System.Drawing.Point(661, 152);
            this.btnOtro.Name = "btnOtro";
            this.btnOtro.Size = new System.Drawing.Size(48, 26);
            this.btnOtro.TabIndex = 80;
            this.btnOtro.Text = "...";
            this.btnOtro.UseVisualStyleBackColor = false;
            // 
            // txtdireccionp
            // 
            this.txtdireccionp.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccionp.Location = new System.Drawing.Point(556, 123);
            this.txtdireccionp.MaxLength = 60;
            this.txtdireccionp.Name = "txtdireccionp";
            this.txtdireccionp.Size = new System.Drawing.Size(100, 23);
            this.txtdireccionp.TabIndex = 55;
            // 
            // mtxtTelefono2
            // 
            this.mtxtTelefono2.Location = new System.Drawing.Point(556, 189);
            this.mtxtTelefono2.Mask = "000-000-0000";
            this.mtxtTelefono2.Name = "mtxtTelefono2";
            this.mtxtTelefono2.Size = new System.Drawing.Size(95, 27);
            this.mtxtTelefono2.TabIndex = 58;
            // 
            // btninsertar
            // 
            this.btninsertar.BackColor = System.Drawing.Color.White;
            this.btninsertar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btninsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btninsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.ForeColor = System.Drawing.Color.Black;
            this.btninsertar.Location = new System.Drawing.Point(425, 17);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(103, 35);
            this.btninsertar.TabIndex = 62;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = false;
            // 
            // mtxtTelefono
            // 
            this.mtxtTelefono.Location = new System.Drawing.Point(316, 184);
            this.mtxtTelefono.Mask = "000-000-0000";
            this.mtxtTelefono.Name = "mtxtTelefono";
            this.mtxtTelefono.Size = new System.Drawing.Size(95, 27);
            this.mtxtTelefono.TabIndex = 57;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(541, 17);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 35);
            this.btnEliminar.TabIndex = 64;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // mtxtCedula
            // 
            this.mtxtCedula.Location = new System.Drawing.Point(556, 88);
            this.mtxtCedula.Mask = "000-0000000-0";
            this.mtxtCedula.Name = "mtxtCedula";
            this.mtxtCedula.Size = new System.Drawing.Size(100, 27);
            this.mtxtCedula.TabIndex = 54;
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.White;
            this.btnactualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnactualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnactualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.Black;
            this.btnactualizar.Location = new System.Drawing.Point(657, 17);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(103, 35);
            this.btnactualizar.TabIndex = 66;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(491, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 79;
            this.label6.Text = "Doctor";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblnombre.ForeColor = System.Drawing.Color.Black;
            this.lblnombre.Location = new System.Drawing.Point(249, 86);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(107, 16);
            this.lblnombre.TabIndex = 65;
            this.lblnombre.Text = "Nombre Paciente";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(556, 154);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(100, 27);
            this.cmbDoctor.TabIndex = 56;
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblapellido.ForeColor = System.Drawing.Color.Black;
            this.lblapellido.Location = new System.Drawing.Point(249, 120);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(107, 16);
            this.lblapellido.TabIndex = 67;
            this.lblapellido.Text = "Apellido Paciente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(249, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 78;
            this.label5.Text = "Seguro";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lbledad.ForeColor = System.Drawing.Color.Black;
            this.lbledad.Location = new System.Drawing.Point(491, 63);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(37, 16);
            this.lbledad.TabIndex = 69;
            this.lbledad.Text = "Edad";
            // 
            // cmbSeguro
            // 
            this.cmbSeguro.FormattingEnabled = true;
            this.cmbSeguro.Location = new System.Drawing.Point(315, 144);
            this.cmbSeguro.Name = "cmbSeguro";
            this.cmbSeguro.Size = new System.Drawing.Size(129, 27);
            this.cmbSeguro.TabIndex = 52;
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblcedula.ForeColor = System.Drawing.Color.Black;
            this.lblcedula.Location = new System.Drawing.Point(491, 95);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(48, 16);
            this.lblcedula.TabIndex = 70;
            this.lblcedula.Text = "Cedula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(692, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 77;
            this.label4.Text = "Alergia";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lbldireccion.ForeColor = System.Drawing.Color.Black;
            this.lbldireccion.Location = new System.Drawing.Point(491, 127);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(62, 16);
            this.lbldireccion.TabIndex = 71;
            this.lbldireccion.Text = "Direccion";
            // 
            // cmbAlergia
            // 
            this.cmbAlergia.FormattingEnabled = true;
            this.cmbAlergia.Location = new System.Drawing.Point(756, 90);
            this.cmbAlergia.Name = "cmbAlergia";
            this.cmbAlergia.Size = new System.Drawing.Size(95, 27);
            this.cmbAlergia.TabIndex = 59;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lbltelefono.ForeColor = System.Drawing.Color.Black;
            this.lbltelefono.Location = new System.Drawing.Point(249, 188);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(56, 16);
            this.lbltelefono.TabIndex = 72;
            this.lbltelefono.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(692, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 76;
            this.label3.Text = "Sexo";
            // 
            // lbltelefonoep
            // 
            this.lbltelefonoep.AutoSize = true;
            this.lbltelefonoep.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lbltelefonoep.ForeColor = System.Drawing.Color.Black;
            this.lbltelefonoep.Location = new System.Drawing.Point(491, 191);
            this.lbltelefonoep.Name = "lbltelefonoep";
            this.lbltelefonoep.Size = new System.Drawing.Size(66, 16);
            this.lbltelefonoep.TabIndex = 73;
            this.lbltelefonoep.Text = "Telefono 2";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(756, 121);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(43, 27);
            this.cmbSexo.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(249, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "ID Paciente";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(756, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 27);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(692, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 75;
            this.label2.Text = "Fecha";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvprincipal
            // 
            this.dgvprincipal.AllowUserToAddRows = false;
            this.dgvprincipal.AllowUserToDeleteRows = false;
            this.dgvprincipal.AllowUserToOrderColumns = true;
            this.dgvprincipal.AllowUserToResizeColumns = false;
            this.dgvprincipal.AllowUserToResizeRows = false;
            this.dgvprincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvprincipal.BackgroundColor = System.Drawing.Color.White;
            this.dgvprincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvprincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvprincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvprincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvprincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPACIENTE,
            this.NOMBREP,
            this.APELLIDOP,
            this.DIRECCIONP,
            this.TELEFONOP,
            this.TELEFONOP2,
            this.SEXOP,
            this.IDTALER,
            this.IDTSEGURO,
            this.IDTDOCTOR});
            this.dgvprincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvprincipal.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvprincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvprincipal.EnableHeadersVisualStyles = false;
            this.dgvprincipal.GridColor = System.Drawing.Color.White;
            this.dgvprincipal.Location = new System.Drawing.Point(0, 0);
            this.dgvprincipal.MultiSelect = false;
            this.dgvprincipal.Name = "dgvprincipal";
            this.dgvprincipal.ReadOnly = true;
            this.dgvprincipal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvprincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvprincipal.RowHeadersVisible = false;
            this.dgvprincipal.RowHeadersWidth = 10;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvprincipal.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvprincipal.RowTemplate.Height = 30;
            this.dgvprincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprincipal.Size = new System.Drawing.Size(1270, 330);
            this.dgvprincipal.TabIndex = 53;
            this.dgvprincipal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprincipal_CellClick);
            // 
            // IDPACIENTE
            // 
            this.IDPACIENTE.DataPropertyName = "IDPACIENTE";
            this.IDPACIENTE.FillWeight = 76.14214F;
            this.IDPACIENTE.HeaderText = "Codigo";
            this.IDPACIENTE.Name = "IDPACIENTE";
            this.IDPACIENTE.ReadOnly = true;
            // 
            // NOMBREP
            // 
            this.NOMBREP.DataPropertyName = "NOMBREP";
            this.NOMBREP.FillWeight = 111.9289F;
            this.NOMBREP.HeaderText = "Nombre Paciente";
            this.NOMBREP.Name = "NOMBREP";
            this.NOMBREP.ReadOnly = true;
            // 
            // APELLIDOP
            // 
            this.APELLIDOP.DataPropertyName = "APELLIDOP";
            this.APELLIDOP.HeaderText = "Apellido Paciente";
            this.APELLIDOP.Name = "APELLIDOP";
            this.APELLIDOP.ReadOnly = true;
            // 
            // DIRECCIONP
            // 
            this.DIRECCIONP.DataPropertyName = "DIRECCIONP";
            this.DIRECCIONP.HeaderText = "Direccion";
            this.DIRECCIONP.Name = "DIRECCIONP";
            this.DIRECCIONP.ReadOnly = true;
            // 
            // TELEFONOP
            // 
            this.TELEFONOP.DataPropertyName = "TELEFONOP";
            this.TELEFONOP.HeaderText = "Telefono";
            this.TELEFONOP.Name = "TELEFONOP";
            this.TELEFONOP.ReadOnly = true;
            // 
            // TELEFONOP2
            // 
            this.TELEFONOP2.DataPropertyName = "TELEFONOP2";
            this.TELEFONOP2.HeaderText = "Telefono 2";
            this.TELEFONOP2.Name = "TELEFONOP2";
            this.TELEFONOP2.ReadOnly = true;
            // 
            // SEXOP
            // 
            this.SEXOP.DataPropertyName = "SEXOP";
            this.SEXOP.HeaderText = "Sexo ";
            this.SEXOP.Name = "SEXOP";
            this.SEXOP.ReadOnly = true;
            // 
            // IDTALER
            // 
            this.IDTALER.DataPropertyName = "IDTALER";
            this.IDTALER.HeaderText = "Codigo Alergia";
            this.IDTALER.Name = "IDTALER";
            this.IDTALER.ReadOnly = true;
            // 
            // IDTSEGURO
            // 
            this.IDTSEGURO.DataPropertyName = "IDTSEGURO";
            this.IDTSEGURO.HeaderText = "Codigo Seguro";
            this.IDTSEGURO.Name = "IDTSEGURO";
            this.IDTSEGURO.ReadOnly = true;
            // 
            // IDTDOCTOR
            // 
            this.IDTDOCTOR.DataPropertyName = "IDTDOCTOR";
            this.IDTDOCTOR.HeaderText = "Codigo Doctor";
            this.IDTDOCTOR.Name = "IDTDOCTOR";
            this.IDTDOCTOR.ReadOnly = true;
            // 
            // FrmPPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1270, 662);
            this.Controls.Add(this.dgvprincipal);
            this.Controls.Add(this.gbprincipal);
            this.Name = "FrmPPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalControlDataSet)).EndInit();
            this.gbprincipal.ResumeLayout(false);
            this.gbprincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MedicalControlDataSet medicalControlDataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private MedicalControlDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.GroupBox gbprincipal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvprincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREP;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCIONP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONOP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTALER;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTSEGURO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTDOCTOR;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnombrep;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox txtapellidop;
        private System.Windows.Forms.TextBox txtedadp;
        private System.Windows.Forms.Button btnOtro;
        private System.Windows.Forms.TextBox txtdireccionp;
        private System.Windows.Forms.MaskedTextBox mtxtTelefono2;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.MaskedTextBox mtxtTelefono;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.MaskedTextBox mtxtCedula;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.ComboBox cmbSeguro;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.ComboBox cmbAlergia;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltelefonoep;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}