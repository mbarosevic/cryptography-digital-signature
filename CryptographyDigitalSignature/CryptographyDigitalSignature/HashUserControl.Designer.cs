namespace CryptographyDigitalSignature
{
    partial class HashUserControl
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
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbxPlainText = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnOpenFileDialog = new MetroSet_UI.Controls.MetroSetButton();
            this.btnCalculateHash = new MetroSet_UI.Controls.MetroSetButton();
            this.tbxHash = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnSaveHashData = new MetroSet_UI.Controls.MetroSetButton();
            this.SuspendLayout();
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.Location = new System.Drawing.Point(43, 44);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(325, 28);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 9;
            this.metroSetLabel3.Text = "Calculate a hash (aka message digest) of data.";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.Location = new System.Drawing.Point(43, 11);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(397, 28);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 10;
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
            this.tbxPlainText.Multiline = true;
            this.tbxPlainText.Name = "tbxPlainText";
            this.tbxPlainText.ReadOnly = false;
            this.tbxPlainText.Size = new System.Drawing.Size(636, 113);
            this.tbxPlainText.Style = MetroSet_UI.Design.Style.Light;
            this.tbxPlainText.StyleManager = null;
            this.tbxPlainText.TabIndex = 11;
            this.tbxPlainText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPlainText.ThemeAuthor = "Narwin";
            this.tbxPlainText.ThemeName = "MetroLite";
            this.tbxPlainText.UseSystemPasswordChar = false;
            this.tbxPlainText.WatermarkText = "";
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
            this.btnOpenFileDialog.Location = new System.Drawing.Point(43, 204);
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
            this.btnOpenFileDialog.TabIndex = 14;
            this.btnOpenFileDialog.Text = "Choose File";
            this.btnOpenFileDialog.ThemeAuthor = "Narwin";
            this.btnOpenFileDialog.ThemeName = "MetroLite";
            // 
            // btnCalculateHash
            // 
            this.btnCalculateHash.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCalculateHash.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCalculateHash.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCalculateHash.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateHash.HoverBorderColor = System.Drawing.Color.Maroon;
            this.btnCalculateHash.HoverColor = System.Drawing.Color.Maroon;
            this.btnCalculateHash.HoverTextColor = System.Drawing.Color.White;
            this.btnCalculateHash.Location = new System.Drawing.Point(43, 249);
            this.btnCalculateHash.Name = "btnCalculateHash";
            this.btnCalculateHash.NormalBorderColor = System.Drawing.Color.Maroon;
            this.btnCalculateHash.NormalColor = System.Drawing.Color.Maroon;
            this.btnCalculateHash.NormalTextColor = System.Drawing.Color.White;
            this.btnCalculateHash.PressBorderColor = System.Drawing.Color.Maroon;
            this.btnCalculateHash.PressColor = System.Drawing.Color.Maroon;
            this.btnCalculateHash.PressTextColor = System.Drawing.Color.White;
            this.btnCalculateHash.Size = new System.Drawing.Size(155, 31);
            this.btnCalculateHash.Style = MetroSet_UI.Design.Style.Custom;
            this.btnCalculateHash.StyleManager = null;
            this.btnCalculateHash.TabIndex = 15;
            this.btnCalculateHash.Text = "Hash";
            this.btnCalculateHash.ThemeAuthor = "Narwin";
            this.btnCalculateHash.ThemeName = "MetroLite";
            this.btnCalculateHash.Click += new System.EventHandler(this.btnCalculateHash_Click);
            // 
            // tbxHash
            // 
            this.tbxHash.AutoCompleteCustomSource = null;
            this.tbxHash.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxHash.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxHash.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbxHash.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbxHash.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbxHash.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbxHash.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHash.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbxHash.Image = null;
            this.tbxHash.Lines = null;
            this.tbxHash.Location = new System.Drawing.Point(43, 312);
            this.tbxHash.MaxLength = 32767;
            this.tbxHash.Multiline = true;
            this.tbxHash.Name = "tbxHash";
            this.tbxHash.ReadOnly = true;
            this.tbxHash.Size = new System.Drawing.Size(636, 113);
            this.tbxHash.Style = MetroSet_UI.Design.Style.Light;
            this.tbxHash.StyleManager = null;
            this.tbxHash.TabIndex = 16;
            this.tbxHash.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxHash.ThemeAuthor = "Narwin";
            this.tbxHash.ThemeName = "MetroLite";
            this.tbxHash.UseSystemPasswordChar = false;
            this.tbxHash.WatermarkText = "";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.Location = new System.Drawing.Point(43, 291);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(397, 18);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 17;
            this.metroSetLabel2.Text = "SHA-256 Hash";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // btnSaveHashData
            // 
            this.btnSaveHashData.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveHashData.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveHashData.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSaveHashData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveHashData.HoverBorderColor = System.Drawing.Color.Maroon;
            this.btnSaveHashData.HoverColor = System.Drawing.Color.Maroon;
            this.btnSaveHashData.HoverTextColor = System.Drawing.Color.White;
            this.btnSaveHashData.Location = new System.Drawing.Point(43, 444);
            this.btnSaveHashData.Name = "btnSaveHashData";
            this.btnSaveHashData.NormalBorderColor = System.Drawing.Color.Maroon;
            this.btnSaveHashData.NormalColor = System.Drawing.Color.Maroon;
            this.btnSaveHashData.NormalTextColor = System.Drawing.Color.White;
            this.btnSaveHashData.PressBorderColor = System.Drawing.Color.Maroon;
            this.btnSaveHashData.PressColor = System.Drawing.Color.Maroon;
            this.btnSaveHashData.PressTextColor = System.Drawing.Color.White;
            this.btnSaveHashData.Size = new System.Drawing.Size(155, 31);
            this.btnSaveHashData.Style = MetroSet_UI.Design.Style.Custom;
            this.btnSaveHashData.StyleManager = null;
            this.btnSaveHashData.TabIndex = 18;
            this.btnSaveHashData.Text = "Save Hash";
            this.btnSaveHashData.ThemeAuthor = "Narwin";
            this.btnSaveHashData.ThemeName = "MetroLite";
            this.btnSaveHashData.Click += new System.EventHandler(this.btnSaveHashData_Click);
            // 
            // HashUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSaveHashData);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.tbxHash);
            this.Controls.Add(this.btnCalculateHash);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.tbxPlainText);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.metroSetLabel3);
            this.Name = "HashUserControl";
            this.Size = new System.Drawing.Size(728, 495);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetTextBox tbxPlainText;
        private MetroSet_UI.Controls.MetroSetButton btnOpenFileDialog;
        private MetroSet_UI.Controls.MetroSetButton btnCalculateHash;
        private MetroSet_UI.Controls.MetroSetTextBox tbxHash;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetButton btnSaveHashData;
    }
}
