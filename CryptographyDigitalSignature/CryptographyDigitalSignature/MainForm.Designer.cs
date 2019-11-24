namespace CryptographyDigitalSignature
{
    partial class MainForm
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
            this.pnlEncrypt = new MetroSet_UI.Controls.MetroSetPanel();
            this.pnlHash = new MetroSet_UI.Controls.MetroSetPanel();
            this.pnlDecrypt = new MetroSet_UI.Controls.MetroSetPanel();
            this.pnlDigitalSignature = new MetroSet_UI.Controls.MetroSetPanel();
            this.btnDigitalSignatureUserControl = new MetroSet_UI.Controls.MetroSetButton();
            this.btnCalculateHashUserControl = new MetroSet_UI.Controls.MetroSetButton();
            this.btnDecryptUserControl = new MetroSet_UI.Controls.MetroSetButton();
            this.btnEncryptUserControl = new MetroSet_UI.Controls.MetroSetButton();
            this.decryptUserControl1 = new CryptographyDigitalSignature.DecryptUserControl();
            this.encryptUserControl1 = new CryptographyDigitalSignature.EncryptUserControl();
            this.hashUserControl1 = new CryptographyDigitalSignature.HashUserControl();
            this.controlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            this.SuspendLayout();
            // 
            // pnlEncrypt
            // 
            this.pnlEncrypt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.pnlEncrypt.BorderColor = System.Drawing.Color.Maroon;
            this.pnlEncrypt.BorderThickness = 1;
            this.pnlEncrypt.Location = new System.Drawing.Point(62, 110);
            this.pnlEncrypt.Name = "pnlEncrypt";
            this.pnlEncrypt.Size = new System.Drawing.Size(94, 4);
            this.pnlEncrypt.Style = MetroSet_UI.Design.Style.Custom;
            this.pnlEncrypt.StyleManager = null;
            this.pnlEncrypt.TabIndex = 24;
            this.pnlEncrypt.ThemeAuthor = "Narwin";
            this.pnlEncrypt.ThemeName = "MetroLite";
            // 
            // pnlHash
            // 
            this.pnlHash.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.pnlHash.BorderColor = System.Drawing.Color.Maroon;
            this.pnlHash.BorderThickness = 1;
            this.pnlHash.Location = new System.Drawing.Point(353, 110);
            this.pnlHash.Name = "pnlHash";
            this.pnlHash.Size = new System.Drawing.Size(148, 4);
            this.pnlHash.Style = MetroSet_UI.Design.Style.Custom;
            this.pnlHash.StyleManager = null;
            this.pnlHash.TabIndex = 25;
            this.pnlHash.ThemeAuthor = "Narwin";
            this.pnlHash.ThemeName = "MetroLite";
            // 
            // pnlDecrypt
            // 
            this.pnlDecrypt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.pnlDecrypt.BorderColor = System.Drawing.Color.Maroon;
            this.pnlDecrypt.BorderThickness = 1;
            this.pnlDecrypt.Location = new System.Drawing.Point(203, 110);
            this.pnlDecrypt.Name = "pnlDecrypt";
            this.pnlDecrypt.Size = new System.Drawing.Size(111, 4);
            this.pnlDecrypt.Style = MetroSet_UI.Design.Style.Custom;
            this.pnlDecrypt.StyleManager = null;
            this.pnlDecrypt.TabIndex = 23;
            this.pnlDecrypt.ThemeAuthor = "Narwin";
            this.pnlDecrypt.ThemeName = "MetroLite";
            // 
            // pnlDigitalSignature
            // 
            this.pnlDigitalSignature.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.pnlDigitalSignature.BorderColor = System.Drawing.Color.Maroon;
            this.pnlDigitalSignature.BorderThickness = 1;
            this.pnlDigitalSignature.Location = new System.Drawing.Point(552, 110);
            this.pnlDigitalSignature.Name = "pnlDigitalSignature";
            this.pnlDigitalSignature.Size = new System.Drawing.Size(182, 4);
            this.pnlDigitalSignature.Style = MetroSet_UI.Design.Style.Custom;
            this.pnlDigitalSignature.StyleManager = null;
            this.pnlDigitalSignature.TabIndex = 22;
            this.pnlDigitalSignature.ThemeAuthor = "Narwin";
            this.pnlDigitalSignature.ThemeName = "MetroLite";
            // 
            // btnDigitalSignatureUserControl
            // 
            this.btnDigitalSignatureUserControl.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDigitalSignatureUserControl.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDigitalSignatureUserControl.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDigitalSignatureUserControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigitalSignatureUserControl.HoverBorderColor = System.Drawing.Color.White;
            this.btnDigitalSignatureUserControl.HoverColor = System.Drawing.Color.White;
            this.btnDigitalSignatureUserControl.HoverTextColor = System.Drawing.Color.Maroon;
            this.btnDigitalSignatureUserControl.Location = new System.Drawing.Point(552, 87);
            this.btnDigitalSignatureUserControl.Name = "btnDigitalSignatureUserControl";
            this.btnDigitalSignatureUserControl.NormalBorderColor = System.Drawing.Color.White;
            this.btnDigitalSignatureUserControl.NormalColor = System.Drawing.Color.White;
            this.btnDigitalSignatureUserControl.NormalTextColor = System.Drawing.Color.Black;
            this.btnDigitalSignatureUserControl.PressBorderColor = System.Drawing.Color.White;
            this.btnDigitalSignatureUserControl.PressColor = System.Drawing.Color.White;
            this.btnDigitalSignatureUserControl.PressTextColor = System.Drawing.Color.Maroon;
            this.btnDigitalSignatureUserControl.Size = new System.Drawing.Size(182, 24);
            this.btnDigitalSignatureUserControl.Style = MetroSet_UI.Design.Style.Custom;
            this.btnDigitalSignatureUserControl.StyleManager = null;
            this.btnDigitalSignatureUserControl.TabIndex = 21;
            this.btnDigitalSignatureUserControl.Text = "Digital signature check";
            this.btnDigitalSignatureUserControl.ThemeAuthor = "Narwin";
            this.btnDigitalSignatureUserControl.ThemeName = "MetroLite";
            this.btnDigitalSignatureUserControl.Click += new System.EventHandler(this.btnDigitalSignature_Click);
            // 
            // btnCalculateHashUserControl
            // 
            this.btnCalculateHashUserControl.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCalculateHashUserControl.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCalculateHashUserControl.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCalculateHashUserControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateHashUserControl.HoverBorderColor = System.Drawing.Color.White;
            this.btnCalculateHashUserControl.HoverColor = System.Drawing.Color.White;
            this.btnCalculateHashUserControl.HoverTextColor = System.Drawing.Color.Maroon;
            this.btnCalculateHashUserControl.Location = new System.Drawing.Point(339, 87);
            this.btnCalculateHashUserControl.Name = "btnCalculateHashUserControl";
            this.btnCalculateHashUserControl.NormalBorderColor = System.Drawing.Color.White;
            this.btnCalculateHashUserControl.NormalColor = System.Drawing.Color.White;
            this.btnCalculateHashUserControl.NormalTextColor = System.Drawing.Color.Black;
            this.btnCalculateHashUserControl.PressBorderColor = System.Drawing.Color.White;
            this.btnCalculateHashUserControl.PressColor = System.Drawing.Color.White;
            this.btnCalculateHashUserControl.PressTextColor = System.Drawing.Color.Maroon;
            this.btnCalculateHashUserControl.Size = new System.Drawing.Size(182, 24);
            this.btnCalculateHashUserControl.Style = MetroSet_UI.Design.Style.Custom;
            this.btnCalculateHashUserControl.StyleManager = null;
            this.btnCalculateHashUserControl.TabIndex = 20;
            this.btnCalculateHashUserControl.Text = "Hash";
            this.btnCalculateHashUserControl.ThemeAuthor = "Narwin";
            this.btnCalculateHashUserControl.ThemeName = "MetroLite";
            this.btnCalculateHashUserControl.Click += new System.EventHandler(this.btnHashUc_Click);
            // 
            // btnDecryptUserControl
            // 
            this.btnDecryptUserControl.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDecryptUserControl.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDecryptUserControl.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDecryptUserControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptUserControl.HoverBorderColor = System.Drawing.Color.White;
            this.btnDecryptUserControl.HoverColor = System.Drawing.Color.White;
            this.btnDecryptUserControl.HoverTextColor = System.Drawing.Color.Maroon;
            this.btnDecryptUserControl.Location = new System.Drawing.Point(185, 87);
            this.btnDecryptUserControl.Name = "btnDecryptUserControl";
            this.btnDecryptUserControl.NormalBorderColor = System.Drawing.Color.White;
            this.btnDecryptUserControl.NormalColor = System.Drawing.Color.White;
            this.btnDecryptUserControl.NormalTextColor = System.Drawing.Color.Black;
            this.btnDecryptUserControl.PressBorderColor = System.Drawing.Color.White;
            this.btnDecryptUserControl.PressColor = System.Drawing.Color.White;
            this.btnDecryptUserControl.PressTextColor = System.Drawing.Color.Maroon;
            this.btnDecryptUserControl.Size = new System.Drawing.Size(148, 24);
            this.btnDecryptUserControl.Style = MetroSet_UI.Design.Style.Custom;
            this.btnDecryptUserControl.StyleManager = null;
            this.btnDecryptUserControl.TabIndex = 19;
            this.btnDecryptUserControl.Text = "Decrypt";
            this.btnDecryptUserControl.ThemeAuthor = "Narwin";
            this.btnDecryptUserControl.ThemeName = "MetroLite";
            this.btnDecryptUserControl.Click += new System.EventHandler(this.btnDecryptUc_Click);
            // 
            // btnEncryptUserControl
            // 
            this.btnEncryptUserControl.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEncryptUserControl.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEncryptUserControl.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnEncryptUserControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptUserControl.HoverBorderColor = System.Drawing.Color.White;
            this.btnEncryptUserControl.HoverColor = System.Drawing.Color.White;
            this.btnEncryptUserControl.HoverTextColor = System.Drawing.Color.Maroon;
            this.btnEncryptUserControl.Location = new System.Drawing.Point(39, 87);
            this.btnEncryptUserControl.Name = "btnEncryptUserControl";
            this.btnEncryptUserControl.NormalBorderColor = System.Drawing.Color.White;
            this.btnEncryptUserControl.NormalColor = System.Drawing.Color.White;
            this.btnEncryptUserControl.NormalTextColor = System.Drawing.Color.Black;
            this.btnEncryptUserControl.PressBorderColor = System.Drawing.Color.White;
            this.btnEncryptUserControl.PressColor = System.Drawing.Color.White;
            this.btnEncryptUserControl.PressTextColor = System.Drawing.Color.Maroon;
            this.btnEncryptUserControl.Size = new System.Drawing.Size(140, 24);
            this.btnEncryptUserControl.Style = MetroSet_UI.Design.Style.Custom;
            this.btnEncryptUserControl.StyleManager = null;
            this.btnEncryptUserControl.TabIndex = 18;
            this.btnEncryptUserControl.Text = "Encrypt";
            this.btnEncryptUserControl.ThemeAuthor = "Narwin";
            this.btnEncryptUserControl.ThemeName = "MetroLite";
            this.btnEncryptUserControl.Click += new System.EventHandler(this.btnEncryptUc_Click);
            // 
            // decryptUserControl1
            // 
            this.decryptUserControl1.BackColor = System.Drawing.Color.White;
            this.decryptUserControl1.Location = new System.Drawing.Point(32, 113);
            this.decryptUserControl1.Name = "decryptUserControl1";
            this.decryptUserControl1.Size = new System.Drawing.Size(728, 495);
            this.decryptUserControl1.TabIndex = 27;
            // 
            // encryptUserControl1
            // 
            this.encryptUserControl1.BackColor = System.Drawing.Color.White;
            this.encryptUserControl1.Location = new System.Drawing.Point(32, 120);
            this.encryptUserControl1.Name = "encryptUserControl1";
            this.encryptUserControl1.Size = new System.Drawing.Size(728, 488);
            this.encryptUserControl1.TabIndex = 26;
            // 
            // hashUserControl1
            // 
            this.hashUserControl1.BackColor = System.Drawing.Color.White;
            this.hashUserControl1.Location = new System.Drawing.Point(39, 113);
            this.hashUserControl1.Name = "hashUserControl1";
            this.hashUserControl1.Size = new System.Drawing.Size(728, 495);
            this.hashUserControl1.TabIndex = 28;
            // 
            // controlBox
            // 
            this.controlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBox.CloseHoverBackColor = System.Drawing.Color.Maroon;
            this.controlBox.CloseHoverForeColor = System.Drawing.SystemColors.Control;
            this.controlBox.CloseNormalForeColor = System.Drawing.SystemColors.Control;
            this.controlBox.DisabledForeColor = System.Drawing.Color.DimGray;
            this.controlBox.Location = new System.Drawing.Point(676, 1);
            this.controlBox.MaximizeBox = true;
            this.controlBox.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.controlBox.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.controlBox.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.controlBox.MinimizeBox = true;
            this.controlBox.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.controlBox.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.controlBox.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(100, 25);
            this.controlBox.Style = MetroSet_UI.Design.Style.Custom;
            this.controlBox.StyleManager = null;
            this.controlBox.TabIndex = 29;
            this.controlBox.Text = "metroSetControlBox1";
            this.controlBox.ThemeAuthor = "Narwin";
            this.controlBox.ThemeName = "MetroLite";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(775, 612);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.pnlEncrypt);
            this.Controls.Add(this.pnlHash);
            this.Controls.Add(this.pnlDecrypt);
            this.Controls.Add(this.pnlDigitalSignature);
            this.Controls.Add(this.btnDigitalSignatureUserControl);
            this.Controls.Add(this.btnCalculateHashUserControl);
            this.Controls.Add(this.btnDecryptUserControl);
            this.Controls.Add(this.btnEncryptUserControl);
            this.Controls.Add(this.hashUserControl1);
            this.Controls.Add(this.decryptUserControl1);
            this.Controls.Add(this.encryptUserControl1);
            this.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.Name = "MainForm";
            this.SmallLineColor1 = System.Drawing.Color.Maroon;
            this.SmallLineColor2 = System.Drawing.Color.Maroon;
            this.Style = MetroSet_UI.Design.Style.Custom;
            this.Text = "Cryptography Digital Signature";
            this.TextColor = System.Drawing.Color.Black;
            this.ThemeName = "MetroDark";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetPanel pnlEncrypt;
        private MetroSet_UI.Controls.MetroSetPanel pnlHash;
        private MetroSet_UI.Controls.MetroSetPanel pnlDecrypt;
        private MetroSet_UI.Controls.MetroSetPanel pnlDigitalSignature;
        private MetroSet_UI.Controls.MetroSetButton btnDigitalSignatureUserControl;
        private MetroSet_UI.Controls.MetroSetButton btnCalculateHashUserControl;
        private MetroSet_UI.Controls.MetroSetButton btnDecryptUserControl;
        private MetroSet_UI.Controls.MetroSetButton btnEncryptUserControl;
        private EncryptUserControl encryptUserControl1;
        private DecryptUserControl decryptUserControl1;
        private HashUserControl hashUserControl1;
        private MetroSet_UI.Controls.MetroSetControlBox controlBox;
    }
}

