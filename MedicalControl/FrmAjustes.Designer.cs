namespace MedicalControl
{
    partial class FrmAjustes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnActualizarDoctor = new System.Windows.Forms.Button();
            this.lbliddoctor = new System.Windows.Forms.Label();
            this.lblnombredoctor = new System.Windows.Forms.Label();
            this.BtnEliminarDoctor = new System.Windows.Forms.Button();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAlergia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEliminarAlergia = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSeguro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEliminarSeguros = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbproveedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnEliminarProveedores = new System.Windows.Forms.Button();
            this.Especialidad = new System.Windows.Forms.Label();
            this.txtexpecialidad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Especialidad);
            this.groupBox1.Controls.Add(this.txtexpecialidad);
            this.groupBox1.Controls.Add(this.BtnActualizarDoctor);
            this.groupBox1.Controls.Add(this.lbliddoctor);
            this.groupBox1.Controls.Add(this.lblnombredoctor);
            this.groupBox1.Controls.Add(this.BtnEliminarDoctor);
            this.groupBox1.Controls.Add(this.txtDoctor);
            this.groupBox1.Controls.Add(this.cmbDoctor);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctores";
            // 
            // BtnActualizarDoctor
            // 
            this.BtnActualizarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.BtnActualizarDoctor.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarDoctor.Location = new System.Drawing.Point(129, 157);
            this.BtnActualizarDoctor.Name = "BtnActualizarDoctor";
            this.BtnActualizarDoctor.Size = new System.Drawing.Size(121, 23);
            this.BtnActualizarDoctor.TabIndex = 5;
            this.BtnActualizarDoctor.Text = "Actualizar";
            this.BtnActualizarDoctor.UseVisualStyleBackColor = false;
            this.BtnActualizarDoctor.Click += new System.EventHandler(this.BtnActualizarDoctor_Click);
            // 
            // lbliddoctor
            // 
            this.lbliddoctor.AutoSize = true;
            this.lbliddoctor.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliddoctor.ForeColor = System.Drawing.Color.White;
            this.lbliddoctor.Location = new System.Drawing.Point(11, 72);
            this.lbliddoctor.Name = "lbliddoctor";
            this.lbliddoctor.Size = new System.Drawing.Size(70, 18);
            this.lbliddoctor.TabIndex = 4;
            this.lbliddoctor.Text = "N. Doctor";
            // 
            // lblnombredoctor
            // 
            this.lblnombredoctor.AutoSize = true;
            this.lblnombredoctor.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombredoctor.ForeColor = System.Drawing.Color.White;
            this.lblnombredoctor.Location = new System.Drawing.Point(11, 33);
            this.lblnombredoctor.Name = "lblnombredoctor";
            this.lblnombredoctor.Size = new System.Drawing.Size(110, 18);
            this.lblnombredoctor.TabIndex = 3;
            this.lblnombredoctor.Text = "Nombre Doctor";
            // 
            // BtnEliminarDoctor
            // 
            this.BtnEliminarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.BtnEliminarDoctor.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarDoctor.Location = new System.Drawing.Point(6, 157);
            this.BtnEliminarDoctor.Name = "BtnEliminarDoctor";
            this.BtnEliminarDoctor.Size = new System.Drawing.Size(121, 23);
            this.BtnEliminarDoctor.TabIndex = 2;
            this.BtnEliminarDoctor.Text = "Eliminar";
            this.BtnEliminarDoctor.UseVisualStyleBackColor = false;
            this.BtnEliminarDoctor.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // txtDoctor
            // 
            this.txtDoctor.Location = new System.Drawing.Point(124, 67);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(121, 26);
            this.txtDoctor.TabIndex = 1;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(124, 30);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(121, 26);
            this.cmbDoctor.TabIndex = 0;
            this.cmbDoctor.SelectedIndexChanged += new System.EventHandler(this.cmbDoctor_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbAlergia);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BtnEliminarAlergia);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(296, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alergias";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(134, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 26);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "N. Alergia";
            // 
            // cmbAlergia
            // 
            this.cmbAlergia.FormattingEnabled = true;
            this.cmbAlergia.Location = new System.Drawing.Point(134, 27);
            this.cmbAlergia.Name = "cmbAlergia";
            this.cmbAlergia.Size = new System.Drawing.Size(121, 26);
            this.cmbAlergia.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre Alergia";
            // 
            // BtnEliminarAlergia
            // 
            this.BtnEliminarAlergia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.BtnEliminarAlergia.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarAlergia.Location = new System.Drawing.Point(134, 112);
            this.BtnEliminarAlergia.Name = "BtnEliminarAlergia";
            this.BtnEliminarAlergia.Size = new System.Drawing.Size(121, 23);
            this.BtnEliminarAlergia.TabIndex = 8;
            this.BtnEliminarAlergia.Text = "Eliminar";
            this.BtnEliminarAlergia.UseVisualStyleBackColor = false;
            this.BtnEliminarAlergia.Click += new System.EventHandler(this.BtnEliminarAlergia_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbSeguro);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.BtnEliminarSeguros);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(9, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 189);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seguros";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(132, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 26);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "N. Seguro";
            // 
            // cmbSeguro
            // 
            this.cmbSeguro.FormattingEnabled = true;
            this.cmbSeguro.Location = new System.Drawing.Point(132, 27);
            this.cmbSeguro.Name = "cmbSeguro";
            this.cmbSeguro.Size = new System.Drawing.Size(121, 26);
            this.cmbSeguro.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre Seguro";
            // 
            // BtnEliminarSeguros
            // 
            this.BtnEliminarSeguros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.BtnEliminarSeguros.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarSeguros.Location = new System.Drawing.Point(132, 112);
            this.BtnEliminarSeguros.Name = "BtnEliminarSeguros";
            this.BtnEliminarSeguros.Size = new System.Drawing.Size(121, 23);
            this.BtnEliminarSeguros.TabIndex = 8;
            this.BtnEliminarSeguros.Text = "Eliminar";
            this.BtnEliminarSeguros.UseVisualStyleBackColor = false;
            this.BtnEliminarSeguros.Click += new System.EventHandler(this.BtnEliminarSeguros_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cbproveedor);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.BtnEliminarProveedores);
            this.groupBox4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(296, 305);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 189);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proveedores";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.button5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(138, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Actualizar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(142, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 26);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "N. Proveedor";
            // 
            // cbproveedor
            // 
            this.cbproveedor.FormattingEnabled = true;
            this.cbproveedor.Location = new System.Drawing.Point(142, 27);
            this.cbproveedor.Name = "cbproveedor";
            this.cbproveedor.Size = new System.Drawing.Size(121, 26);
            this.cbproveedor.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre Proveedor";
            // 
            // BtnEliminarProveedores
            // 
            this.BtnEliminarProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.BtnEliminarProveedores.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProveedores.Location = new System.Drawing.Point(138, 112);
            this.BtnEliminarProveedores.Name = "BtnEliminarProveedores";
            this.BtnEliminarProveedores.Size = new System.Drawing.Size(121, 23);
            this.BtnEliminarProveedores.TabIndex = 8;
            this.BtnEliminarProveedores.Text = "Eliminar";
            this.BtnEliminarProveedores.UseVisualStyleBackColor = false;
            this.BtnEliminarProveedores.Click += new System.EventHandler(this.BtnEliminarProveedores_Click);
            // 
            // Especialidad
            // 
            this.Especialidad.AutoSize = true;
            this.Especialidad.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Especialidad.ForeColor = System.Drawing.Color.White;
            this.Especialidad.Location = new System.Drawing.Point(11, 111);
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.Size = new System.Drawing.Size(70, 18);
            this.Especialidad.TabIndex = 7;
            this.Especialidad.Text = "N. Doctor";
            // 
            // txtexpecialidad
            // 
            this.txtexpecialidad.Location = new System.Drawing.Point(124, 104);
            this.txtexpecialidad.Name = "txtexpecialidad";
            this.txtexpecialidad.Size = new System.Drawing.Size(121, 26);
            this.txtexpecialidad.TabIndex = 6;
            // 
            // FrmAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(608, 559);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAjustes";
            this.Text = "FrmAjustes";
            this.Load += new System.EventHandler(this.FrmAjustes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnActualizarDoctor;
        private System.Windows.Forms.Label lbliddoctor;
        private System.Windows.Forms.Label lblnombredoctor;
        private System.Windows.Forms.Button BtnEliminarDoctor;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAlergia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEliminarAlergia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSeguro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEliminarSeguros;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbproveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnEliminarProveedores;
        private System.Windows.Forms.Label Especialidad;
        private System.Windows.Forms.TextBox txtexpecialidad;
    }
}