namespace UserConfigurationApp
{
    partial class frmUserSettings
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
            btnConfirm = new Button();
            btnSaveSettings = new Button();
            btnLoadSettings = new Button();
            btnUploadPicture = new Button();
            picProfile = new PictureBox();
            label1 = new Label();
            chkEmail = new CheckBox();
            chkSMS = new CheckBox();
            grpRole = new GroupBox();
            rdoUser = new RadioButton();
            rdoAdmin = new RadioButton();
            label2 = new Label();
            cmbDepartment = new ComboBox();
            label3 = new Label();
            lstNotifications = new ListBox();
            label4 = new Label();
            clbAdvancedOptions = new CheckedListBox();
            label5 = new Label();
            dtpDateOfEntry = new DateTimePicker();
            label6 = new Label();
            numExperience = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            grpRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numExperience).BeginInit();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(31, 497);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(196, 50);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Confirmar";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.Location = new Point(282, 497);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(196, 50);
            btnSaveSettings.TabIndex = 1;
            btnSaveSettings.Text = "Guardar";
            btnSaveSettings.UseVisualStyleBackColor = true;
            btnSaveSettings.Click += btnSaveSettings_Click;
            // 
            // btnLoadSettings
            // 
            btnLoadSettings.Location = new Point(560, 497);
            btnLoadSettings.Name = "btnLoadSettings";
            btnLoadSettings.Size = new Size(196, 50);
            btnLoadSettings.TabIndex = 2;
            btnLoadSettings.Text = "Cargar Configuración";
            btnLoadSettings.UseVisualStyleBackColor = true;
            btnLoadSettings.Click += btnLoadSettings_Click;
            // 
            // btnUploadPicture
            // 
            btnUploadPicture.Location = new Point(29, 31);
            btnUploadPicture.Name = "btnUploadPicture";
            btnUploadPicture.Size = new Size(196, 29);
            btnUploadPicture.TabIndex = 3;
            btnUploadPicture.Text = "Seleccionar foto del perfil";
            btnUploadPicture.UseVisualStyleBackColor = true;
            btnUploadPicture.Click += btnUploadPicture_Click;
            // 
            // picProfile
            // 
            picProfile.Location = new Point(43, 66);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(170, 170);
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfile.TabIndex = 4;
            picProfile.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 239);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
            label1.TabIndex = 5;
            label1.Text = "Preferencias de comunicación:";
            // 
            // chkEmail
            // 
            chkEmail.AutoSize = true;
            chkEmail.Location = new Point(46, 262);
            chkEmail.Name = "chkEmail";
            chkEmail.Size = new Size(68, 24);
            chkEmail.TabIndex = 6;
            chkEmail.Text = "Email";
            chkEmail.UseVisualStyleBackColor = true;
            // 
            // chkSMS
            // 
            chkSMS.AutoSize = true;
            chkSMS.Location = new Point(153, 262);
            chkSMS.Name = "chkSMS";
            chkSMS.Size = new Size(60, 24);
            chkSMS.TabIndex = 7;
            chkSMS.Text = "SMS";
            chkSMS.UseVisualStyleBackColor = true;
            // 
            // grpRole
            // 
            grpRole.Controls.Add(rdoUser);
            grpRole.Controls.Add(rdoAdmin);
            grpRole.Location = new Point(43, 296);
            grpRole.Name = "grpRole";
            grpRole.Size = new Size(196, 114);
            grpRole.TabIndex = 8;
            grpRole.TabStop = false;
            grpRole.Text = "Rol de Usuario";
            // 
            // rdoUser
            // 
            rdoUser.AutoSize = true;
            rdoUser.Location = new Point(15, 73);
            rdoUser.Name = "rdoUser";
            rdoUser.Size = new Size(135, 24);
            rdoUser.TabIndex = 1;
            rdoUser.TabStop = true;
            rdoUser.Text = "Usuario Regular";
            rdoUser.UseVisualStyleBackColor = true;
            // 
            // rdoAdmin
            // 
            rdoAdmin.AutoSize = true;
            rdoAdmin.Location = new Point(15, 32);
            rdoAdmin.Name = "rdoAdmin";
            rdoAdmin.Size = new Size(125, 24);
            rdoAdmin.TabIndex = 0;
            rdoAdmin.TabStop = true;
            rdoAdmin.Text = "Administrador";
            rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 296);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 9;
            label2.Text = "Departamento:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "Tecnología", "Ventas", "Marketing", "Recursos Humanos" });
            cmbDepartment.Location = new Point(284, 328);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(151, 28);
            cmbDepartment.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(583, 21);
            label3.Name = "label3";
            label3.Size = new Size(195, 20);
            label3.TabIndex = 11;
            label3.Text = "Preferencias de notificación:";
            // 
            // lstNotifications
            // 
            lstNotifications.FormattingEnabled = true;
            lstNotifications.Items.AddRange(new object[] { "Actualizaciones de sistema", "Alertas de seguridad", "Boletines informativos" });
            lstNotifications.Location = new Point(583, 57);
            lstNotifications.Name = "lstNotifications";
            lstNotifications.SelectionMode = SelectionMode.MultiExtended;
            lstNotifications.Size = new Size(247, 104);
            lstNotifications.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(583, 197);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 13;
            label4.Text = "Opciones avanzadas:";
            // 
            // clbAdvancedOptions
            // 
            clbAdvancedOptions.FormattingEnabled = true;
            clbAdvancedOptions.Items.AddRange(new object[] { "Modo Avanzado", "Respaldo automático", "Notificación en tiempo real" });
            clbAdvancedOptions.Location = new Point(583, 239);
            clbAdvancedOptions.Name = "clbAdvancedOptions";
            clbAdvancedOptions.Size = new Size(247, 114);
            clbAdvancedOptions.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(284, 94);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 15;
            label5.Text = "Fecha de ingreso:";
            // 
            // dtpDateOfEntry
            // 
            dtpDateOfEntry.Format = DateTimePickerFormat.Short;
            dtpDateOfEntry.Location = new Point(284, 134);
            dtpDateOfEntry.Name = "dtpDateOfEntry";
            dtpDateOfEntry.Size = new Size(153, 27);
            dtpDateOfEntry.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(284, 182);
            label6.Name = "label6";
            label6.Size = new Size(192, 20);
            label6.TabIndex = 17;
            label6.Text = "Nivel de experiencia (años):";
            // 
            // numExperience
            // 
            numExperience.Location = new Point(285, 209);
            numExperience.Name = "numExperience";
            numExperience.Size = new Size(150, 27);
            numExperience.TabIndex = 18;
            // 
            // frmUserSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 594);
            Controls.Add(numExperience);
            Controls.Add(label6);
            Controls.Add(dtpDateOfEntry);
            Controls.Add(label5);
            Controls.Add(clbAdvancedOptions);
            Controls.Add(label4);
            Controls.Add(lstNotifications);
            Controls.Add(label3);
            Controls.Add(cmbDepartment);
            Controls.Add(label2);
            Controls.Add(grpRole);
            Controls.Add(chkSMS);
            Controls.Add(chkEmail);
            Controls.Add(label1);
            Controls.Add(picProfile);
            Controls.Add(btnUploadPicture);
            Controls.Add(btnLoadSettings);
            Controls.Add(btnSaveSettings);
            Controls.Add(btnConfirm);
            Name = "frmUserSettings";
            Text = "Configuración de Usuario";
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            grpRole.ResumeLayout(false);
            grpRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numExperience).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private Button btnSaveSettings;
        private Button btnLoadSettings;
        private Button btnUploadPicture;
        private PictureBox picProfile;
        private Label label1;
        private CheckBox chkEmail;
        private CheckBox chkSMS;
        private GroupBox grpRole;
        private RadioButton rdoUser;
        private RadioButton rdoAdmin;
        private Label label2;
        private ComboBox cmbDepartment;
        private Label label3;
        private ListBox lstNotifications;
        private Label label4;
        private CheckedListBox clbAdvancedOptions;
        private Label label5;
        private DateTimePicker dtpDateOfEntry;
        private Label label6;
        private NumericUpDown numExperience;
    }
}