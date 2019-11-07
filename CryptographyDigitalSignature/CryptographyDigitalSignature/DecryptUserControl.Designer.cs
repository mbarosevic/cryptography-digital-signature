﻿namespace CryptographyDigitalSignature
{
    partial class DecryptUserControl
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
            this.cbxDecryptionAlgorithm = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnOpenFileDialog = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnDecrypt = new MetroSet_UI.Controls.MetroSetButton();
            this.tbxDecryptedText = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbxEncryptedText = new MetroSet_UI.Controls.MetroSetTextBox();
            this.SuspendLayout();
            // 
            // cbxDecryptionAlgorithm
            // 
            this.cbxDecryptionAlgorithm.AllowDrop = true;
            this.cbxDecryptionAlgorithm.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbxDecryptionAlgorithm.BackColor = System.Drawing.Color.Transparent;
            this.cbxDecryptionAlgorithm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbxDecryptionAlgorithm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbxDecryptionAlgorithm.CausesValidation = false;
            this.cbxDecryptionAlgorithm.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbxDecryptionAlgorithm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbxDecryptionAlgorithm.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbxDecryptionAlgorithm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDecryptionAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDecryptionAlgorithm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDecryptionAlgorithm.FormattingEnabled = true;
            this.cbxDecryptionAlgorithm.ItemHeight = 20;
            this.cbxDecryptionAlgorithm.Location = new System.Drawing.Point(271, 43);
            this.cbxDecryptionAlgorithm.Name = "cbxDecryptionAlgorithm";
            this.cbxDecryptionAlgorithm.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbxDecryptionAlgorithm.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbxDecryptionAlgorithm.Size = new System.Drawing.Size(121, 26);
            this.cbxDecryptionAlgorithm.Style = MetroSet_UI.Design.Style.Light;
            this.cbxDecryptionAlgorithm.StyleManager = null;
            this.cbxDecryptionAlgorithm.TabIndex = 23;
            this.cbxDecryptionAlgorithm.ThemeAuthor = "Narwin";
            this.cbxDecryptionAlgorithm.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.Location = new System.Drawing.Point(46, 45);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(219, 28);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 22;
            this.metroSetLabel3.Text = "Choose decryption algorithm";
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
            this.btnOpenFileDialog.Location = new System.Drawing.Point(46, 252);
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
            this.btnOpenFileDialog.TabIndex = 21;
            this.btnOpenFileDialog.Text = "Odaberi datoteku";
            this.btnOpenFileDialog.ThemeAuthor = "Narwin";
            this.btnOpenFileDialog.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.Location = new System.Drawing.Point(46, 292);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(397, 18);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 20;
            this.metroSetLabel2.Text = "Dekriptiran tekst";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDecrypt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDecrypt.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.HoverBorderColor = System.Drawing.Color.Maroon;
            this.btnDecrypt.HoverColor = System.Drawing.Color.Maroon;
            this.btnDecrypt.HoverTextColor = System.Drawing.Color.White;
            this.btnDecrypt.Location = new System.Drawing.Point(220, 252);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.NormalBorderColor = System.Drawing.Color.Maroon;
            this.btnDecrypt.NormalColor = System.Drawing.Color.Maroon;
            this.btnDecrypt.NormalTextColor = System.Drawing.Color.White;
            this.btnDecrypt.PressBorderColor = System.Drawing.Color.Maroon;
            this.btnDecrypt.PressColor = System.Drawing.Color.Maroon;
            this.btnDecrypt.PressTextColor = System.Drawing.Color.White;
            this.btnDecrypt.Size = new System.Drawing.Size(155, 31);
            this.btnDecrypt.Style = MetroSet_UI.Design.Style.Custom;
            this.btnDecrypt.StyleManager = null;
            this.btnDecrypt.TabIndex = 19;
            this.btnDecrypt.Text = "Dekriptiraj";
            this.btnDecrypt.ThemeAuthor = "Narwin";
            this.btnDecrypt.ThemeName = "MetroLite";
            // 
            // tbxDecryptedText
            // 
            this.tbxDecryptedText.AutoCompleteCustomSource = null;
            this.tbxDecryptedText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxDecryptedText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxDecryptedText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbxDecryptedText.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbxDecryptedText.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbxDecryptedText.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbxDecryptedText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDecryptedText.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbxDecryptedText.Image = null;
            this.tbxDecryptedText.Lines = null;
            this.tbxDecryptedText.Location = new System.Drawing.Point(46, 312);
            this.tbxDecryptedText.MaxLength = 32767;
            this.tbxDecryptedText.Multiline = true;
            this.tbxDecryptedText.Name = "tbxDecryptedText";
            this.tbxDecryptedText.ReadOnly = true;
            this.tbxDecryptedText.Size = new System.Drawing.Size(636, 170);
            this.tbxDecryptedText.Style = MetroSet_UI.Design.Style.Light;
            this.tbxDecryptedText.StyleManager = null;
            this.tbxDecryptedText.TabIndex = 18;
            this.tbxDecryptedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxDecryptedText.ThemeAuthor = "Narwin";
            this.tbxDecryptedText.ThemeName = "MetroLite";
            this.tbxDecryptedText.UseSystemPasswordChar = false;
            this.tbxDecryptedText.WatermarkText = "";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.Location = new System.Drawing.Point(46, 12);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(397, 28);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 17;
            this.metroSetLabel1.Text = "Choose a text file or enter text";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
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
            this.tbxEncryptedText.Location = new System.Drawing.Point(46, 76);
            this.tbxEncryptedText.MaxLength = 32767;
            this.tbxEncryptedText.Multiline = false;
            this.tbxEncryptedText.Name = "tbxEncryptedText";
            this.tbxEncryptedText.ReadOnly = false;
            this.tbxEncryptedText.Size = new System.Drawing.Size(636, 170);
            this.tbxEncryptedText.Style = MetroSet_UI.Design.Style.Light;
            this.tbxEncryptedText.StyleManager = null;
            this.tbxEncryptedText.TabIndex = 16;
            this.tbxEncryptedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxEncryptedText.ThemeAuthor = "Narwin";
            this.tbxEncryptedText.ThemeName = "MetroLite";
            this.tbxEncryptedText.UseSystemPasswordChar = false;
            this.tbxEncryptedText.WatermarkText = "";
            // 
            // DecryptUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbxDecryptionAlgorithm);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.tbxDecryptedText);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.tbxEncryptedText);
            this.Name = "DecryptUserControl";
            this.Size = new System.Drawing.Size(728, 495);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetComboBox cbxDecryptionAlgorithm;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetButton btnOpenFileDialog;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetButton btnDecrypt;
        private MetroSet_UI.Controls.MetroSetTextBox tbxDecryptedText;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetTextBox tbxEncryptedText;
    }
}