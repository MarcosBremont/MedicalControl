namespace MedicalControl
{
    partial class FrmMantenimiento
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtcodigoseguro = new System.Windows.Forms.TextBox();
            this.dgvsegurom = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.txtnombreseguro = new System.Windows.Forms.TextBox();
            this.lblcodigoseguro = new System.Windows.Forms.Label();
            this.lblnombreseguro = new System.Windows.Forms.Label();
            this.BtnEliminarSeguros = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtubicacionproveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombreproveedor = new System.Windows.Forms.TextBox();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.lblidproveedor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcodigoproveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvproveedor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UbicacionProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnEliminarProveedores = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsegurom)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtcodigoseguro);
            this.groupBox3.Controls.Add(this.dgvsegurom);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.txtnombreseguro);
            this.groupBox3.Controls.Add(this.lblcodigoseguro);
            this.groupBox3.Controls.Add(this.lblnombreseguro);
            this.groupBox3.Controls.Add(this.BtnEliminarSeguros);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(48, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 242);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seguros";
            // 
            // txtcodigoseguro
            // 
            this.txtcodigoseguro.Location = new System.Drawing.Point(124, 30);
            this.txtcodigoseguro.Name = "txtcodigoseguro";
            this.txtcodigoseguro.Size = new System.Drawing.Size(91, 26);
            this.txtcodigoseguro.TabIndex = 12;
            // 
            // dgvsegurom
            // 
            this.dgvsegurom.AllowUserToAddRows = false;
            this.dgvsegurom.AllowUserToDeleteRows = false;
            this.dgvsegurom.AllowUserToOrderColumns = true;
            this.dgvsegurom.AllowUserToResizeColumns = false;
            this.dgvsegurom.AllowUserToResizeRows = false;
            this.dgvsegurom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsegurom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvsegurom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvsegurom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsegurom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsegurom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsegurom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvsegurom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvsegurom.EnableHeadersVisualStyles = false;
            this.dgvsegurom.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvsegurom.Location = new System.Drawing.Point(221, 28);
            this.dgvsegurom.MultiSelect = false;
            this.dgvsegurom.Name = "dgvsegurom";
            this.dgvsegurom.ReadOnly = true;
            this.dgvsegurom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvsegurom.RowHeadersVisible = false;
            this.dgvsegurom.RowHeadersWidth = 10;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvsegurom.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvsegurom.RowTemplate.Height = 30;
            this.dgvsegurom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsegurom.Size = new System.Drawing.Size(213, 193);
            this.dgvsegurom.TabIndex = 10;
            this.dgvsegurom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsegurom_CellClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDSEGURO";
            this.dataGridViewTextBoxColumn3.FillWeight = 60.9137F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NombreSeguro";
            this.dataGridViewTextBoxColumn4.FillWeight = 139.0863F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre Seguro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(113, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtnombreseguro
            // 
            this.txtnombreseguro.Location = new System.Drawing.Point(124, 79);
            this.txtnombreseguro.Name = "txtnombreseguro";
            this.txtnombreseguro.Size = new System.Drawing.Size(91, 26);
            this.txtnombreseguro.TabIndex = 7;
            this.txtnombreseguro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombreseguro_KeyPress);
            // 
            // lblcodigoseguro
            // 
            this.lblcodigoseguro.AutoSize = true;
            this.lblcodigoseguro.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigoseguro.ForeColor = System.Drawing.Color.White;
            this.lblcodigoseguro.Location = new System.Drawing.Point(7, 33);
            this.lblcodigoseguro.Name = "lblcodigoseguro";
            this.lblcodigoseguro.Size = new System.Drawing.Size(73, 18);
            this.lblcodigoseguro.TabIndex = 10;
            this.lblcodigoseguro.Text = "N. Seguro";
            // 
            // lblnombreseguro
            // 
            this.lblnombreseguro.AutoSize = true;
            this.lblnombreseguro.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreseguro.ForeColor = System.Drawing.Color.White;
            this.lblnombreseguro.Location = new System.Drawing.Point(7, 83);
            this.lblnombreseguro.Name = "lblnombreseguro";
            this.lblnombreseguro.Size = new System.Drawing.Size(113, 18);
            this.lblnombreseguro.TabIndex = 9;
            this.lblnombreseguro.Text = "Nombre Seguro";
            // 
            // BtnEliminarSeguros
            // 
            this.BtnEliminarSeguros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.BtnEliminarSeguros.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarSeguros.Location = new System.Drawing.Point(7, 167);
            this.BtnEliminarSeguros.Name = "BtnEliminarSeguros";
            this.BtnEliminarSeguros.Size = new System.Drawing.Size(100, 23);
            this.BtnEliminarSeguros.TabIndex = 8;
            this.BtnEliminarSeguros.Text = "Eliminar";
            this.BtnEliminarSeguros.UseVisualStyleBackColor = false;
            this.BtnEliminarSeguros.Click += new System.EventHandler(this.BtnEliminarSeguros_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mtxtTelefono);
            this.groupBox4.Controls.Add(this.txtcorreo);
            this.groupBox4.Controls.Add(this.txtubicacionproveedor);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtnombreproveedor);
            this.groupBox4.Controls.Add(this.lblNombreProveedor);
            this.groupBox4.Controls.Add(this.lblidproveedor);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtcodigoproveedor);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.dgvproveedor);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.BtnEliminarProveedores);
            this.groupBox4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(326, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(649, 242);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proveedores";
            // 
            // mtxtTelefono
            // 
            this.mtxtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mtxtTelefono.Location = new System.Drawing.Point(373, 156);
            this.mtxtTelefono.Mask = "000-000-0000";
            this.mtxtTelefono.Name = "mtxtTelefono";
            this.mtxtTelefono.Size = new System.Drawing.Size(100, 26);
            this.mtxtTelefono.TabIndex = 38;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(529, 162);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(114, 26);
            this.txtcorreo.TabIndex = 18;
            // 
            // txtubicacionproveedor
            // 
            this.txtubicacionproveedor.Location = new System.Drawing.Point(379, 202);
            this.txtubicacionproveedor.Name = "txtubicacionproveedor";
            this.txtubicacionproveedor.Size = new System.Drawing.Size(94, 26);
            this.txtubicacionproveedor.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(474, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Correo";
            // 
            // txtnombreproveedor
            // 
            this.txtnombreproveedor.Location = new System.Drawing.Point(138, 201);
            this.txtnombreproveedor.Name = "txtnombreproveedor";
            this.txtnombreproveedor.Size = new System.Drawing.Size(89, 26);
            this.txtnombreproveedor.TabIndex = 7;
            this.txtnombreproveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombreproveedor_KeyPress);
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProveedor.ForeColor = System.Drawing.Color.White;
            this.lblNombreProveedor.Location = new System.Drawing.Point(5, 203);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(135, 18);
            this.lblNombreProveedor.TabIndex = 10;
            this.lblNombreProveedor.Text = "Nombre Proveedor";
            // 
            // lblidproveedor
            // 
            this.lblidproveedor.AutoSize = true;
            this.lblidproveedor.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidproveedor.ForeColor = System.Drawing.Color.White;
            this.lblidproveedor.Location = new System.Drawing.Point(5, 167);
            this.lblidproveedor.Name = "lblidproveedor";
            this.lblidproveedor.Size = new System.Drawing.Size(126, 18);
            this.lblidproveedor.TabIndex = 9;
            this.lblidproveedor.Text = "Codigo Proveedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(231, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ubicacion Proveedor";
            // 
            // txtcodigoproveedor
            // 
            this.txtcodigoproveedor.Location = new System.Drawing.Point(138, 161);
            this.txtcodigoproveedor.Name = "txtcodigoproveedor";
            this.txtcodigoproveedor.Size = new System.Drawing.Size(89, 26);
            this.txtcodigoproveedor.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Telefono Proveedor";
            // 
            // dgvproveedor
            // 
            this.dgvproveedor.AllowUserToAddRows = false;
            this.dgvproveedor.AllowUserToDeleteRows = false;
            this.dgvproveedor.AllowUserToOrderColumns = true;
            this.dgvproveedor.AllowUserToResizeColumns = false;
            this.dgvproveedor.AllowUserToResizeRows = false;
            this.dgvproveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproveedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvproveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvproveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.UbicacionProveedor,
            this.TelefonoProveedor,
            this.Correo});
            this.dgvproveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvproveedor.EnableHeadersVisualStyles = false;
            this.dgvproveedor.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvproveedor.Location = new System.Drawing.Point(99, 25);
            this.dgvproveedor.MultiSelect = false;
            this.dgvproveedor.Name = "dgvproveedor";
            this.dgvproveedor.ReadOnly = true;
            this.dgvproveedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvproveedor.RowHeadersVisible = false;
            this.dgvproveedor.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvproveedor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvproveedor.RowTemplate.Height = 30;
            this.dgvproveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproveedor.Size = new System.Drawing.Size(544, 126);
            this.dgvproveedor.TabIndex = 12;
            this.dgvproveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproveedor_CellClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idt_proveedor";
            this.dataGridViewTextBoxColumn5.FillWeight = 55.77103F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NombreProveedor";
            this.dataGridViewTextBoxColumn6.FillWeight = 150.3046F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre Proveedor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // UbicacionProveedor
            // 
            this.UbicacionProveedor.DataPropertyName = "UbicacionProveedor";
            this.UbicacionProveedor.FillWeight = 59.69785F;
            this.UbicacionProveedor.HeaderText = "Ubicacion";
            this.UbicacionProveedor.Name = "UbicacionProveedor";
            this.UbicacionProveedor.ReadOnly = true;
            // 
            // TelefonoProveedor
            // 
            this.TelefonoProveedor.DataPropertyName = "TelefonoProveedor";
            this.TelefonoProveedor.FillWeight = 73.20798F;
            this.TelefonoProveedor.HeaderText = "Telefono";
            this.TelefonoProveedor.Name = "TelefonoProveedor";
            this.TelefonoProveedor.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.FillWeight = 84.01857F;
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.button5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(8, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Actualizar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnEliminarProveedores
            // 
            this.BtnEliminarProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.BtnEliminarProveedores.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProveedores.Location = new System.Drawing.Point(8, 73);
            this.BtnEliminarProveedores.Name = "BtnEliminarProveedores";
            this.BtnEliminarProveedores.Size = new System.Drawing.Size(85, 23);
            this.BtnEliminarProveedores.TabIndex = 8;
            this.BtnEliminarProveedores.Text = "Eliminar";
            this.BtnEliminarProveedores.UseVisualStyleBackColor = false;
            this.BtnEliminarProveedores.Click += new System.EventHandler(this.BtnEliminarProveedores_Click);
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1124, 559);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmMantenimiento";
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.FrmAjustes_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsegurom)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtnombreseguro;
        private System.Windows.Forms.Label lblcodigoseguro;
        private System.Windows.Forms.Label lblnombreseguro;
        private System.Windows.Forms.Button BtnEliminarSeguros;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtnombreproveedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.Label lblidproveedor;
        private System.Windows.Forms.Button BtnEliminarProveedores;
        private System.Windows.Forms.TextBox txtcodigoseguro;
        private System.Windows.Forms.DataGridView dgvsegurom;
        private System.Windows.Forms.TextBox txtubicacionproveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcodigoproveedor;
        private System.Windows.Forms.DataGridView dgvproveedor;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn UbicacionProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.MaskedTextBox mtxtTelefono;
    }
}