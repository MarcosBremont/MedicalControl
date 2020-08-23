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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalControlDataSet = new MedicalControl.MedicalControlDataSet();
            this.pacienteTableAdapter = new MedicalControl.MedicalControlDataSetTableAdapters.PacienteTableAdapter();
            this.txtnombrep = new System.Windows.Forms.TextBox();
            this.txtedadp = new System.Windows.Forms.TextBox();
            this.txtapellidop = new System.Windows.Forms.TextBox();
            this.txtdireccionp = new System.Windows.Forms.TextBox();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblcedula = new System.Windows.Forms.Label();
            this.lbltelefonoep = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAlergia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSeguro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.mtxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefono2 = new System.Windows.Forms.MaskedTextBox();
            this.btnOtro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.gbprincipal = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
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
            // txtnombrep
            // 
            this.txtnombrep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtnombrep.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrep.Location = new System.Drawing.Point(375, 101);
            this.txtnombrep.MaxLength = 30;
            this.txtnombrep.Name = "txtnombrep";
            this.txtnombrep.Size = new System.Drawing.Size(83, 23);
            this.txtnombrep.TabIndex = 0;
            this.txtnombrep.TextChanged += new System.EventHandler(this.txtnombrep_TextChanged);
            this.txtnombrep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombrep_KeyPress);
            // 
            // txtedadp
            // 
            this.txtedadp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtedadp.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtedadp.Location = new System.Drawing.Point(569, 70);
            this.txtedadp.MaxLength = 3;
            this.txtedadp.Name = "txtedadp";
            this.txtedadp.Size = new System.Drawing.Size(48, 23);
            this.txtedadp.TabIndex = 3;
            this.txtedadp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedadp_KeyPress);
            // 
            // txtapellidop
            // 
            this.txtapellidop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtapellidop.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidop.Location = new System.Drawing.Point(375, 134);
            this.txtapellidop.MaxLength = 30;
            this.txtapellidop.Name = "txtapellidop";
            this.txtapellidop.Size = new System.Drawing.Size(83, 23);
            this.txtapellidop.TabIndex = 1;
            this.txtapellidop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidop_KeyPress);
            // 
            // txtdireccionp
            // 
            this.txtdireccionp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtdireccionp.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccionp.Location = new System.Drawing.Point(569, 133);
            this.txtdireccionp.MaxLength = 60;
            this.txtdireccionp.Name = "txtdireccionp";
            this.txtdireccionp.Size = new System.Drawing.Size(100, 23);
            this.txtdireccionp.TabIndex = 5;
            // 
            // btninsertar
            // 
            this.btninsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btninsertar.BackColor = System.Drawing.Color.White;
            this.btninsertar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btninsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btninsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.ForeColor = System.Drawing.Color.Black;
            this.btninsertar.Location = new System.Drawing.Point(439, 24);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(103, 35);
            this.btninsertar.TabIndex = 12;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = false;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(555, 24);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 35);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnactualizar.BackColor = System.Drawing.Color.White;
            this.btnactualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnactualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnactualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.Black;
            this.btnactualizar.Location = new System.Drawing.Point(671, 24);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(103, 35);
            this.btnactualizar.TabIndex = 14;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // lblid
            // 
            this.lblid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(378, 76);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 16);
            this.lblid.TabIndex = 13;
            // 
            // lblnombre
            // 
            this.lblnombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblnombre.ForeColor = System.Drawing.Color.Black;
            this.lblnombre.Location = new System.Drawing.Point(263, 108);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(107, 16);
            this.lblnombre.TabIndex = 14;
            this.lblnombre.Text = "Nombre Paciente";
            // 
            // lbledad
            // 
            this.lbledad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lbledad.ForeColor = System.Drawing.Color.Black;
            this.lbledad.Location = new System.Drawing.Point(505, 76);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(37, 16);
            this.lbledad.TabIndex = 16;
            this.lbledad.Text = "Edad";
            // 
            // lblapellido
            // 
            this.lblapellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblapellido.ForeColor = System.Drawing.Color.Black;
            this.lblapellido.Location = new System.Drawing.Point(263, 141);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(107, 16);
            this.lblapellido.TabIndex = 15;
            this.lblapellido.Text = "Apellido Paciente";
            // 
            // lbldireccion
            // 
            this.lbldireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lbldireccion.ForeColor = System.Drawing.Color.Black;
            this.lbldireccion.Location = new System.Drawing.Point(505, 138);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(62, 16);
            this.lbldireccion.TabIndex = 18;
            this.lbldireccion.Text = "Direccion";
            // 
            // lblcedula
            // 
            this.lblcedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblcedula.AutoSize = true;
            this.lblcedula.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblcedula.ForeColor = System.Drawing.Color.Black;
            this.lblcedula.Location = new System.Drawing.Point(505, 107);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(48, 16);
            this.lblcedula.TabIndex = 17;
            this.lblcedula.Text = "Cedula";
            // 
            // lbltelefonoep
            // 
            this.lbltelefonoep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltelefonoep.AutoSize = true;
            this.lbltelefonoep.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lbltelefonoep.ForeColor = System.Drawing.Color.Black;
            this.lbltelefonoep.Location = new System.Drawing.Point(690, 107);
            this.lbltelefonoep.Name = "lbltelefonoep";
            this.lbltelefonoep.Size = new System.Drawing.Size(66, 16);
            this.lbltelefonoep.TabIndex = 20;
            this.lbltelefonoep.Text = "Telefono 2";
            // 
            // lbltelefono
            // 
            this.lbltelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lbltelefono.ForeColor = System.Drawing.Color.Black;
            this.lbltelefono.Location = new System.Drawing.Point(690, 76);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(56, 16);
            this.lbltelefono.TabIndex = 19;
            this.lbltelefono.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(263, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID Paciente";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(897, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(946, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 27);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // cmbSexo
            // 
            this.cmbSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(946, 104);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(43, 27);
            this.cmbSexo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(897, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Sexo";
            // 
            // cmbAlergia
            // 
            this.cmbAlergia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbAlergia.FormattingEnabled = true;
            this.cmbAlergia.Location = new System.Drawing.Point(757, 133);
            this.cmbAlergia.Name = "cmbAlergia";
            this.cmbAlergia.Size = new System.Drawing.Size(100, 27);
            this.cmbAlergia.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(690, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Alergia";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(263, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Seguro";
            // 
            // cmbSeguro
            // 
            this.cmbSeguro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbSeguro.FormattingEnabled = true;
            this.cmbSeguro.Location = new System.Drawing.Point(329, 167);
            this.cmbSeguro.Name = "cmbSeguro";
            this.cmbSeguro.Size = new System.Drawing.Size(129, 27);
            this.cmbSeguro.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(505, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Doctor";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(569, 166);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(100, 27);
            this.cmbDoctor.TabIndex = 6;
            // 
            // mtxtCedula
            // 
            this.mtxtCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mtxtCedula.Location = new System.Drawing.Point(569, 103);
            this.mtxtCedula.Mask = "000-0000000-0";
            this.mtxtCedula.Name = "mtxtCedula";
            this.mtxtCedula.Size = new System.Drawing.Size(100, 27);
            this.mtxtCedula.TabIndex = 4;
            // 
            // mtxtTelefono
            // 
            this.mtxtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mtxtTelefono.Location = new System.Drawing.Point(757, 75);
            this.mtxtTelefono.Mask = "000-000-0000";
            this.mtxtTelefono.Name = "mtxtTelefono";
            this.mtxtTelefono.Size = new System.Drawing.Size(100, 27);
            this.mtxtTelefono.TabIndex = 7;
            // 
            // mtxtTelefono2
            // 
            this.mtxtTelefono2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mtxtTelefono2.Location = new System.Drawing.Point(757, 104);
            this.mtxtTelefono2.Mask = "000-000-0000";
            this.mtxtTelefono2.Name = "mtxtTelefono2";
            this.mtxtTelefono2.Size = new System.Drawing.Size(100, 27);
            this.mtxtTelefono2.TabIndex = 8;
            // 
            // btnOtro
            // 
            this.btnOtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOtro.BackColor = System.Drawing.Color.White;
            this.btnOtro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOtro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOtro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnOtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtro.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtro.ForeColor = System.Drawing.Color.Black;
            this.btnOtro.Location = new System.Drawing.Point(675, 165);
            this.btnOtro.Name = "btnOtro";
            this.btnOtro.Size = new System.Drawing.Size(48, 26);
            this.btnOtro.TabIndex = 40;
            this.btnOtro.Text = "...";
            this.btnOtro.UseVisualStyleBackColor = false;
            this.btnOtro.Click += new System.EventHandler(this.btnOtro_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(463, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 27);
            this.button1.TabIndex = 41;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(863, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 27);
            this.button2.TabIndex = 42;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCantidad.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.ForeColor = System.Drawing.Color.DarkRed;
            this.TxtCantidad.Location = new System.Drawing.Point(362, 27);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.ReadOnly = true;
            this.TxtCantidad.Size = new System.Drawing.Size(45, 23);
            this.TxtCantidad.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(298, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Cantidad";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbuscar.Location = new System.Drawing.Point(100, 29);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 27);
            this.txtbuscar.TabIndex = 48;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            this.txtbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscar_KeyUp);
            // 
            // lblbuscar
            // 
            this.lblbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblbuscar.ForeColor = System.Drawing.Color.Black;
            this.lblbuscar.Location = new System.Drawing.Point(44, 35);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(49, 16);
            this.lblbuscar.TabIndex = 49;
            this.lblbuscar.Text = "Buscar";
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
            this.gbprincipal.Location = new System.Drawing.Point(30, 371);
            this.gbprincipal.Name = "gbprincipal";
            this.gbprincipal.Size = new System.Drawing.Size(1104, 242);
            this.gbprincipal.TabIndex = 50;
            this.gbprincipal.TabStop = false;
            this.gbprincipal.Text = "Paciente";
            this.gbprincipal.Enter += new System.EventHandler(this.gbprincipal_Enter);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(38, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "Exportar a Excel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.dgvprincipal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvprincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvprincipal.BackgroundColor = System.Drawing.Color.White;
            this.dgvprincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvprincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvprincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvprincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvprincipal.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvprincipal.EnableHeadersVisualStyles = false;
            this.dgvprincipal.GridColor = System.Drawing.Color.White;
            this.dgvprincipal.Location = new System.Drawing.Point(30, 23);
            this.dgvprincipal.MultiSelect = false;
            this.dgvprincipal.Name = "dgvprincipal";
            this.dgvprincipal.ReadOnly = true;
            this.dgvprincipal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvprincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvprincipal.RowHeadersVisible = false;
            this.dgvprincipal.RowHeadersWidth = 10;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvprincipal.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvprincipal.RowTemplate.Height = 30;
            this.dgvprincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprincipal.Size = new System.Drawing.Size(1080, 330);
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
            this.ClientSize = new System.Drawing.Size(1218, 613);
            this.Controls.Add(this.dgvprincipal);
            this.Controls.Add(this.gbprincipal);
            this.MaximumSize = new System.Drawing.Size(1234, 652);
            this.MinimumSize = new System.Drawing.Size(1234, 652);
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
        private System.Windows.Forms.TextBox txtnombrep;
        private System.Windows.Forms.TextBox txtedadp;
        private System.Windows.Forms.TextBox txtapellidop;
        private System.Windows.Forms.TextBox txtdireccionp;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.Label lbltelefonoep;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAlergia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSeguro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.MaskedTextBox mtxtCedula;
        private System.Windows.Forms.MaskedTextBox mtxtTelefono;
        private System.Windows.Forms.MaskedTextBox mtxtTelefono2;
        private System.Windows.Forms.Button btnOtro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.GroupBox gbprincipal;
        private System.Windows.Forms.Button button3;
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
    }
}