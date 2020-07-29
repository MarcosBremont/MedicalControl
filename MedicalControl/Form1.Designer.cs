namespace MedicalControl
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alergiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citaMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.ibminimize = new FontAwesome.Sharp.IconButton();
            this.ibmaximize = new FontAwesome.Sharp.IconButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.ibsalir = new FontAwesome.Sharp.IconButton();
            this.ibajustes = new FontAwesome.Sharp.IconButton();
            this.ibinventario = new FontAwesome.Sharp.IconButton();
            this.ibcitasmedicas = new FontAwesome.Sharp.IconButton();
            this.ibpaginaprincipal = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.ibsalir);
            this.panelMenu.Controls.Add(this.ibajustes);
            this.panelMenu.Controls.Add(this.ibinventario);
            this.panelMenu.Controls.Add(this.ibcitasmedicas);
            this.panelMenu.Controls.Add(this.ibpaginaprincipal);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 662);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.iconButton3);
            this.panelTitleBar.Controls.Add(this.ibminimize);
            this.panelTitleBar.Controls.Add(this.ibmaximize);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1050, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTitleChildForm.Location = new System.Drawing.Point(63, 30);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(44, 23);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Inicio";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1050, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.menuStrip1);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1050, 578);
            this.panelDesktop.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorToolStripMenuItem,
            this.alergiaToolStripMenuItem,
            this.seguroToolStripMenuItem,
            this.citaMedicaToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doctorToolStripMenuItem.Text = "Doctor";
            this.doctorToolStripMenuItem.Click += new System.EventHandler(this.doctorToolStripMenuItem_Click);
            // 
            // alergiaToolStripMenuItem
            // 
            this.alergiaToolStripMenuItem.Name = "alergiaToolStripMenuItem";
            this.alergiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alergiaToolStripMenuItem.Text = "Alergia";
            this.alergiaToolStripMenuItem.Click += new System.EventHandler(this.alergiaToolStripMenuItem_Click);
            // 
            // seguroToolStripMenuItem
            // 
            this.seguroToolStripMenuItem.Name = "seguroToolStripMenuItem";
            this.seguroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seguroToolStripMenuItem.Text = "Seguro";
            this.seguroToolStripMenuItem.Click += new System.EventHandler(this.seguroToolStripMenuItem_Click);
            // 
            // citaMedicaToolStripMenuItem
            // 
            this.citaMedicaToolStripMenuItem.Name = "citaMedicaToolStripMenuItem";
            this.citaMedicaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.citaMedicaToolStripMenuItem.Text = "Proveedor";
            this.citaMedicaToolStripMenuItem.Click += new System.EventHandler(this.citaMedicaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::MedicalControl.Properties.Resources.MEDICAL_CONTROL__1__removebg1;
            this.pictureBox1.Location = new System.Drawing.Point(423, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconSize = 20;
            this.iconButton3.Location = new System.Drawing.Point(1018, 2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(29, 23);
            this.iconButton3.TabIndex = 5;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click_1);
            // 
            // ibminimize
            // 
            this.ibminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibminimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ibminimize.FlatAppearance.BorderSize = 0;
            this.ibminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibminimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibminimize.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.ibminimize.IconColor = System.Drawing.Color.White;
            this.ibminimize.IconSize = 16;
            this.ibminimize.Location = new System.Drawing.Point(952, 1);
            this.ibminimize.Name = "ibminimize";
            this.ibminimize.Rotation = 0D;
            this.ibminimize.Size = new System.Drawing.Size(29, 23);
            this.ibminimize.TabIndex = 4;
            this.ibminimize.UseVisualStyleBackColor = false;
            this.ibminimize.Click += new System.EventHandler(this.ibminimize_Click);
            // 
            // ibmaximize
            // 
            this.ibmaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibmaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ibmaximize.FlatAppearance.BorderSize = 0;
            this.ibmaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibmaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibmaximize.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.ibmaximize.IconColor = System.Drawing.Color.White;
            this.ibmaximize.IconSize = 16;
            this.ibmaximize.Location = new System.Drawing.Point(985, 1);
            this.ibmaximize.Name = "ibmaximize";
            this.ibmaximize.Rotation = 0D;
            this.ibmaximize.Size = new System.Drawing.Size(29, 23);
            this.ibmaximize.TabIndex = 3;
            this.ibmaximize.UseVisualStyleBackColor = false;
            this.ibmaximize.Click += new System.EventHandler(this.ibmaximize_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(23, 25);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(38, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // ibsalir
            // 
            this.ibsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibsalir.FlatAppearance.BorderSize = 0;
            this.ibsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibsalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibsalir.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibsalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibsalir.IconChar = FontAwesome.Sharp.IconChar.Walking;
            this.ibsalir.IconColor = System.Drawing.Color.White;
            this.ibsalir.IconSize = 40;
            this.ibsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibsalir.Location = new System.Drawing.Point(0, 591);
            this.ibsalir.Name = "ibsalir";
            this.ibsalir.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.ibsalir.Rotation = 0D;
            this.ibsalir.Size = new System.Drawing.Size(220, 60);
            this.ibsalir.TabIndex = 6;
            this.ibsalir.Text = "Salir";
            this.ibsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibsalir.UseVisualStyleBackColor = true;
            this.ibsalir.Click += new System.EventHandler(this.ibsalir_Click);
            // 
            // ibajustes
            // 
            this.ibajustes.FlatAppearance.BorderSize = 0;
            this.ibajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibajustes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibajustes.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibajustes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibajustes.IconChar = FontAwesome.Sharp.IconChar.Sun;
            this.ibajustes.IconColor = System.Drawing.Color.White;
            this.ibajustes.IconSize = 40;
            this.ibajustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibajustes.Location = new System.Drawing.Point(0, 449);
            this.ibajustes.Name = "ibajustes";
            this.ibajustes.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.ibajustes.Rotation = 0D;
            this.ibajustes.Size = new System.Drawing.Size(220, 60);
            this.ibajustes.TabIndex = 5;
            this.ibajustes.Text = "Ajustes";
            this.ibajustes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibajustes.UseVisualStyleBackColor = true;
            this.ibajustes.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // ibinventario
            // 
            this.ibinventario.FlatAppearance.BorderSize = 0;
            this.ibinventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibinventario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibinventario.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibinventario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibinventario.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.ibinventario.IconColor = System.Drawing.Color.White;
            this.ibinventario.IconSize = 40;
            this.ibinventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibinventario.Location = new System.Drawing.Point(0, 356);
            this.ibinventario.Name = "ibinventario";
            this.ibinventario.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.ibinventario.Rotation = 0D;
            this.ibinventario.Size = new System.Drawing.Size(220, 60);
            this.ibinventario.TabIndex = 4;
            this.ibinventario.Text = "Inventario";
            this.ibinventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibinventario.UseVisualStyleBackColor = true;
            this.ibinventario.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // ibcitasmedicas
            // 
            this.ibcitasmedicas.FlatAppearance.BorderSize = 0;
            this.ibcitasmedicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibcitasmedicas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibcitasmedicas.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibcitasmedicas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibcitasmedicas.IconChar = FontAwesome.Sharp.IconChar.Medkit;
            this.ibcitasmedicas.IconColor = System.Drawing.Color.White;
            this.ibcitasmedicas.IconSize = 40;
            this.ibcitasmedicas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibcitasmedicas.Location = new System.Drawing.Point(0, 263);
            this.ibcitasmedicas.Name = "ibcitasmedicas";
            this.ibcitasmedicas.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.ibcitasmedicas.Rotation = 0D;
            this.ibcitasmedicas.Size = new System.Drawing.Size(220, 60);
            this.ibcitasmedicas.TabIndex = 3;
            this.ibcitasmedicas.Text = "Citas Medicas";
            this.ibcitasmedicas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibcitasmedicas.UseVisualStyleBackColor = true;
            this.ibcitasmedicas.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // ibpaginaprincipal
            // 
            this.ibpaginaprincipal.FlatAppearance.BorderSize = 0;
            this.ibpaginaprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibpaginaprincipal.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibpaginaprincipal.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibpaginaprincipal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibpaginaprincipal.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.ibpaginaprincipal.IconColor = System.Drawing.Color.White;
            this.ibpaginaprincipal.IconSize = 40;
            this.ibpaginaprincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibpaginaprincipal.Location = new System.Drawing.Point(0, 170);
            this.ibpaginaprincipal.Name = "ibpaginaprincipal";
            this.ibpaginaprincipal.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.ibpaginaprincipal.Rotation = 0D;
            this.ibpaginaprincipal.Size = new System.Drawing.Size(220, 60);
            this.ibpaginaprincipal.TabIndex = 2;
            this.ibpaginaprincipal.Text = "Pagina Principal";
            this.ibpaginaprincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibpaginaprincipal.UseVisualStyleBackColor = true;
            this.ibpaginaprincipal.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::MedicalControl.Properties.Resources.MEDICAL_CONTROL__1__removebg1;
            this.btnHome.Location = new System.Drawing.Point(8, 25);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(205, 81);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 662);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1032, 680);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPrincipal_MouseDown);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton ibajustes;
        private FontAwesome.Sharp.IconButton ibinventario;
        private FontAwesome.Sharp.IconButton ibcitasmedicas;
        private FontAwesome.Sharp.IconButton ibpaginaprincipal;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton ibsalir;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton ibminimize;
        private FontAwesome.Sharp.IconButton ibmaximize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alergiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citaMedicaToolStripMenuItem;
    }
}

