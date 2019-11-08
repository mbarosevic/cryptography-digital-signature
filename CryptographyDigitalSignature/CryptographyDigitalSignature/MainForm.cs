﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
namespace CryptographyDigitalSignature
{
    public partial class MainForm : MetroSetForm
    {
        public MainForm()
        {
            InitializeComponent();
            HidePanels();
            pnlEncrypt.Show();
            decryptUserControl1.Hide();
            encryptUserControl1.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEncryptUc_Click(object sender, EventArgs e)
        {
            HidePanels();
            decryptUserControl1.Hide();
            pnlEncrypt.Show();
            encryptUserControl1.Show();
        }

        private void btnDecryptUc_Click(object sender, EventArgs e)
        {
            HidePanels();
            encryptUserControl1.Hide();
            pnlDecrypt.Show();
            decryptUserControl1.Show();
        }

        private void btnHashUc_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlHash.Show();
        }

        private void btnDigitalSignature_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlDigitalSignature.Show();
        }

        private void HidePanels()
        {
            foreach(Control c in this.Controls)
            {
                if(c is Panel)
                {
                    c.Visible = false;
                }
            }
        }

        public string OpenFileDialog()
        {
            string fileContent = string.Empty;
            string path = string.Empty;

            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = @"C:\";
                openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFile.FilterIndex = 2;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    path = openFile.FileName;
                    var fileStream = openFile.OpenFile();
                    using (StreamReader sr = new StreamReader(fileStream))
                    {
                        fileContent = sr.ReadToEnd();
                    }
                }
            }
            return fileContent;
        }

        public void SaveFileDialog(string key, string iv)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                using(StreamWriter swSaveKey = File.CreateText(fileName))
                {
                    swSaveKey.WriteLine(key + Environment.NewLine + iv);
                }
            }
        }
    }
}
