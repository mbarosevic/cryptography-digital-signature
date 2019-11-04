﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyDigitalSignature
{
    public partial class EncryptUserControl : UserControl
    {
        public EncryptUserControl()
        {
            InitializeComponent();

            cbxEncryptionAlgorithm.Items.Add("AES");
            cbxEncryptionAlgorithm.SelectedIndex = 0;
        }
        Aes aes = new Aes();

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if(tbxPlainText.Text == "")
            {
                MessageBox.Show("Please choose text file or input text!");
            }
            else
            {
                Encrypt(tbxPlainText.Text);
            }
        }

        public void Encrypt(string plainText)
        {
            tbxEncryptedText.Text = aes.Encrypt(plainText);
        }
    }
}
