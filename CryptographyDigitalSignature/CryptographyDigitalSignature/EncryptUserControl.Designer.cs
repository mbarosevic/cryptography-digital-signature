namespace CryptographyDigitalSignature
{
    partial class EncryptUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxEncryptionAlgorithm = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnOpenFileDialog = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnEncrypt = new MetroSet_UI.Controls.MetroSetButton();
            this.tbxEncryptedText = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbxPlainText = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnSaveSecretKeyAndIv = new MetroSet_UI.Controls.MetroSetButton();
            this.btnSaveEncryptedText = new MetroSet_UI.Controls.MetroSetButton();
            this.lblChosenFile = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblEncryptionStatus = new MetroSet_UI.Controls.MetroSetLabel();
            this.SuspendLayout();
            // 
            // cbxEncryptionAlgorithm
            // 
            this.cbxEncryptionAlgorithm.AllowDrop = true;
            this.cbxEncryptionAlgorithm.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbxEncryptionAlgorithm.BackColor = System.Drawing.Color.Transparent;
            this.cbxEncryptionAlgorithm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbxEncryptionAlgorithm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbxEncryptionAlgorithm.CausesValidation = false;
            this.cbxEncryptionAlgorithm.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbxEncryptionAlgorithm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbxEncryptionAlgorithm.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbxEncryptionAlgorithm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxEncryptionAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEncryptionAlgorithm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEncryptionAlgorithm.FormattingEnabled = true;
            this.cbxEncryptionAlgorithm.ItemHeight = 20;
            this.cbxEncryptionAlgorithm.Location = new System.Drawing.Point(250, 43);
            this.cbxEncryptionAlgorithm.Name = "cbxEncryptionAlgorithm";
            this.cbxEncryptionAlgorithm.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbxEncryptionAlgorithm.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbxEncryptionAlgorithm.Size = new System.Drawing.Size(121, 26);
            this.cbxEncryptionAlgorithm.Style = MetroSet_UI.Design.Style.Light;
            this.cbxEncryptionAlgorithm.StyleManager = null;
            this.cbxEncryptionAlgorithm.TabIndex = 15;
            this.cbxEncryptionAlgorithm.ThemeAuthor = "Narwin";
            this.cbxEncryptionAlgorithm.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.Location = new System.Drawing.Point(43, 44);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(202, 28);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 14;
            this.metroSetLabel3.Text = "Choose encryption algorithm";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnOpenFileDialog.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnOpenFileDialog.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnOpenFileDialog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFileDialog.HoverBorderColor = System.Drawing.Color.Maroon;
            this.btnOpenFileDialog.HoverColor = System.Drawing.Color.Maroon;
            this.btnOpenFileDialog.HoverTextColor = System.Drawing.Color.White;
            this.btnOpenFileDialog.Location = new System.Drawing.Point(43, 185);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.NormalBorderColor = System.Drawing.Color.Maroon;
            this.btnOpenFileDialog.NormalColor = System.Drawing.Color.Maroon;
            this.btnOpenFileDialog.NormalTextColor = System.Drawing.Color.White;
            this.btnOpenFileDialog.PressBorderColor = System.Drawing.Color.Maroon;
            this.btnOpenFileDialog.PressColor = System.Drawing.Color.Maroon;
            this.btnOpenFileDialog.PressTextColor = System.Drawing.Color.White;
            this.btnOpenFileDialog.Size = new System.Drawing.Size(155, 31);
            this.btnOpenFileDialog.Style = MetroSet_UI.Design.Style.Custom;
            this.btnOpenFileDialog.StyleManager = null;
            this.btnOpenFileDialog.TabIndex = 13;
            this.btnOpenFileDialog.Text = "Choose File";
            this.btnOpenFileDialog.ThemeAuthor = "Narwin";
            this.btnOpenFileDialog.ThemeName = "MetroLite";
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.Location = new System.Drawing.Point(43, 272);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(397, 18);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 12;
            this.metroSetLabel2.Text = "Encrypted Text";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEncrypt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEncrypt.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.HoverBorderColor = System.Drawing.Color.Maroon;
            this.btnEncrypt.HoverColor = System.Drawing.Color.Maroon;
            this.btnEncrypt.HoverTextColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(43, 230);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.NormalBorderColor = System.Drawing.Color.Maroon;
            this.btnEncrypt.NormalColor = System.Drawing.Color.Maroon;
            this.btnEncrypt.NormalTextColor = System.Drawing.Color.White;
            this.btnEncrypt.PressBorderColor = System.Drawing.Color.Maroon;
            this.btnEncrypt.PressColor = System.Drawing.Color.Maroon;
            this.btnEncrypt.PressTextColor = System.Drawing.Color.White;
            this.btnEncrypt.Size = new System.Drawing.Size(155, 31);
            this.btnEncrypt.Style = MetroSet_UI.Design.Style.Custom;
            this.btnEncrypt.StyleManager = null;
            this.btnEncrypt.TabIndex = 11;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.ThemeAuthor = "Narwin";
            this.btnEncrypt.ThemeName = "MetroLite";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbxEncryptedText
            // 
            this.tbxEncryptedText.AutoCompleteCustomSource = null;
            this.tbxEncryptedText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxEncryptedText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxEncryptedText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbxEncryptedText.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbxEncryptedText.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbxEncryptedText.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbxEncryptedText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEncryptedText.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbxEncryptedText.Image = null;
            this.tbxEncryptedText.Lines = null;
            this.tbxEncryptedText.Location = new System.Drawing.Point(43, 293);
            this.tbxEncryptedText.MaxLength = 32767;
            this.tbxEncryptedText.Multiline = true;
            this.tbxEncryptedText.Name = "tbxEncryptedText";
            this.tbxEncryptedText.ReadOnly = true;
            this.tbxEncryptedText.Size = new System.Drawing.Size(636, 98);
            this.tbxEncryptedText.Style = MetroSet_UI.Design.Style.Light;
            this.tbxEncryptedText.StyleManager = null;
            this.tbxEncryptedText.TabIndex = 10;
            this.tbxEncryptedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxEncryptedText.ThemeAuthor = "Narwin";
            this.tbxEncryptedText.ThemeName = "MetroLite";
            this.tbxEncryptedText.UseSystemPasswordChar = false;
            this.tbxEncryptedText.WatermarkText = "";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.Location = new System.Drawing.Point(43, 11);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(397, 28);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 9;
            this.metroSetLabel1.Text = "Choose a text file or enter text";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // tbxPlainText
            // 
            this.tbxPlainText.AutoCompleteCustomSource = null;
            this.tbxPlainText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxPlainText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxPlainText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbxPlainText.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbxPlainText.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbxPlainText.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbxPlainText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlainText.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbxPlainText.Image = null;
            this.tbxPlainText.Lines = null;
            this.tbxPlainText.Location = new System.Drawing.Point(43, 75);
            this.tbxPlainText.MaxLength = 32767;
            this.tbxPlainText.Multiline = false;
            this.tbxPlainText.Name = "tbxPlainText";
            this.tbxPlainText.ReadOnly = false;
            this.tbxPlainText.Size = new System.Drawing.Size(636, 91);
            this.tbxPlainText.Style = MetroSet_UI.Design.Style.Light;
            this.tbxPlainText.StyleManager = null;
            this.tbxPlainText.TabIndex = 8;
            this.tbxPlainText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPlainText.ThemeAuthor = "Narwin";
            this.tbxPlainText.ThemeName = "MetroLite";
            this.tbxPlainText.UseSystemPasswordChar = false;
            this.tbxPlainText.WatermarkText = "";
            // 
            // btnSaveSecretKeyAndIv
            // 
            this.btnSaveSecretKeyAndIv.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveSecretKeyAndIv.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveSecretKeyAndIv.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSaveSecretKeyAndIv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSecretKeyAndIv.HoverBorderColor = System.Drawing.Color.Maroon;
            this.btnSaveSecretKeyAndIv.HoverColor = System.Drawing.Color.Maroon;
            this.btnSaveSecretKeyAndIv.HoverTextColor = System.Drawing.Color.White;
            this.btnSaveSecretKeyAndIv.Location = new System.Drawing.Point(43, 446);
            this.btnSaveSecretKeyAndIv.Name = "btnSaveSecretKeyAndIv";
            this.btnSaveSecretKeyAndIv.NormalBorderColor = System.Drawing.Color.Maroon;
            this.btnSaveSecretKeyAndIv.NormalColor = System.Drawing.Color.Maroon;
            this.btnSaveSecretKeyAndIv.NormalTextColor = System.Drawing.Color.White;
            this.btnSaveSecretKeyAndIv.PressBorderColor = System.Drawing.Color.Maroon;
            this.btnSaveSecretKeyAndIv.PressColor = System.Drawing.Color.Maroon;
            this.btnSaveSecretKeyAndIv.PressTextColor = System.Drawing.Color.White;
            this.btnSaveSecretKeyAndIv.Size = new System.Drawing.Size(155, 31);
            this.btnSaveSecretKeyAndIv.Style = MetroSet_UI.Design.Style.Custom;
            this.btnSaveSecretKeyAndIv.StyleManager = null;
            this.btnSaveSecretKeyAndIv.TabIndex = 16;
            this.btnSaveSecretKeyAndIv.Text = "Save Key and IV";
            this.btnSaveSecretKeyAndIv.ThemeAuthor = "Narwin";
            this.btnSaveSecretKeyAndIv.ThemeName = "MetroLite";
            this.btnSaveSecretKeyAndIv.Click += new System.EventHandler(this.btnSaveSecretKey_Click);
            // 
            // btnSaveEncryptedText
            // 
            this.btnSaveEncryptedText.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveEncryptedText.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveEncryptedText.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSaveEncryptedText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEncryptedText.HoverBorderColor = System.Drawing.Color.Maroon;
            this.btnSaveEncryptedText.HoverColor = System.Drawing.Color.Maroon;
            this.btnSaveEncryptedText.HoverTextColor = System.Drawing.Color.White;
            this.btnSaveEncryptedText.Location = new System.Drawing.Point(43, 403);
            this.btnSaveEncryptedText.Name = "btnSaveEncryptedText";
            this.btnSaveEncryptedText.NormalBorderColor = System.Drawing.Color.Maroon;
            this.btnSaveEncryptedText.NormalColor = System.Drawing.Color.Maroon;
            this.btnSaveEncryptedText.NormalTextColor = System.Drawing.Color.White;
            this.btnSaveEncryptedText.PressBorderColor = System.Drawing.Color.Maroon;
            this.btnSaveEncryptedText.PressColor = System.Drawing.Color.Maroon;
            this.btnSaveEncryptedText.PressTextColor = System.Drawing.Color.White;
            this.btnSaveEncryptedText.Size = new System.Drawing.Size(155, 31);
            this.btnSaveEncryptedText.Style = MetroSet_UI.Design.Style.Custom;
            this.btnSaveEncryptedText.StyleManager = null;
            this.btnSaveEncryptedText.TabIndex = 17;
            this.btnSaveEncryptedText.Text = "Save encrypted text";
            this.btnSaveEncryptedText.ThemeAuthor = "Narwin";
            this.btnSaveEncryptedText.ThemeName = "MetroLite";
            this.btnSaveEncryptedText.Click += new System.EventHandler(this.btnSaveEncryptedText_Click);
            // 
            // lblChosenFile
            // 
            this.lblChosenFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChosenFile.Location = new System.Drawing.Point(225, 188);
            this.lblChosenFile.Name = "lblChosenFile";
            this.lblChosenFile.Size = new System.Drawing.Size(397, 25);
            this.lblChosenFile.Style = MetroSet_UI.Design.Style.Light;
            this.lblChosenFile.StyleManager = null;
            this.lblChosenFile.TabIndex = 18;
            this.lblChosenFile.ThemeAuthor = "Narwin";
            this.lblChosenFile.ThemeName = "MetroLite";
            // 
            // lblEncryptionStatus
            // 
            this.lblEncryptionStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncryptionStatus.Location = new System.Drawing.Point(225, 233);
            this.lblEncryptionStatus.Name = "lblEncryptionStatus";
            this.lblEncryptionStatus.Size = new System.Drawing.Size(397, 25);
            this.lblEncryptionStatus.Style = MetroSet_UI.Design.Style.Light;
            this.lblEncryptionStatus.StyleManager = null;
            this.lblEncryptionStatus.TabIndex = 19;
            this.lblEncryptionStatus.ThemeAuthor = "Narwin";
            this.lblEncryptionStatus.ThemeName = "MetroLite";
            // 
            // EncryptUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblEncryptionStatus);
            this.Controls.Add(this.lblChosenFile);
            this.Controls.Add(this.btnSaveEncryptedText);
            this.Controls.Add(this.btnSaveSecretKeyAndIv);
            this.Controls.Add(this.cbxEncryptionAlgorithm);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbxEncryptedText);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.tbxPlainText);
            this.Name = "EncryptUserControl";
            this.Size = new System.Drawing.Size(728, 495);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetComboBox cbxEncryptionAlgorithm;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetButton btnOpenFileDialog;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetButton btnEncrypt;
        private MetroSet_UI.Controls.MetroSetTextBox tbxEncryptedText;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetTextBox tbxPlainText;
        private MetroSet_UI.Controls.MetroSetButton btnSaveSecretKeyAndIv;
        private MetroSet_UI.Controls.MetroSetButton btnSaveEncryptedText;
        private MetroSet_UI.Controls.MetroSetLabel lblChosenFile;
        private MetroSet_UI.Controls.MetroSetLabel lblEncryptionStatus;
    }
}
