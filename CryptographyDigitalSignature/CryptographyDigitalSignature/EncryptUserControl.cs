using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace CryptographyDigitalSignature
{
    public partial class EncryptUserControl : UserControl
    {
        public EncryptUserControl()
        {
            InitializeComponent();

            cbxEncryptionAlgorithm.Items.Add("AES");
            cbxEncryptionAlgorithm.Items.Add("RSA");
            cbxEncryptionAlgorithm.SelectedIndex = 0;
        }
        MainForm mainForm;
        AesAlgorithm aesAlg = new AesAlgorithm();
        RsaAlgorithm rsaAlg = new RsaAlgorithm();

        string plainText = string.Empty;
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = tbxPlainText.Text;
            if(plainText == "")
            {
                MessageBox.Show("Please choose text file or input text!");
            }
            else
            {
                if(cbxEncryptionAlgorithm.SelectedIndex == 0)
                {
                    EncryptAes(plainText);
                }
                else
                {
                    tbxEncryptedText.Text = rsaAlg.Encrypt(plainText);
                }
            }
        }
        private string key = string.Empty;
        private string iv = string.Empty;
        public void EncryptAes(string plainText)
        {
            try
            {
                using (Aes aes = Aes.Create())
                {
                    byte[] encrypted = aesAlg.EncryptToByteArray(plainText, aes.Key, aes.IV);
                    tbxEncryptedText.Text = Convert.ToBase64String(encrypted);
                    key = Convert.ToBase64String(aes.Key);
                    iv = Convert.ToBase64String(aes.IV);
                    lblEncryptionStatus.Text = "Text encrypted successfully!";
                }
            }
            catch
            {
                lblEncryptionStatus.Text = "Encryption failed";
            }
            
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            tbxPlainText.Text = "";
            tbxEncryptedText.Text = "";
            mainForm = new MainForm();
            plainText = mainForm.OpenFileDialog();
            if(mainForm.path != "")
            {
                lblChosenFile.Text = "Path: " + mainForm.path;
            }
            tbxPlainText.Text = plainText;
        }

        private void btnSaveSecretKey_Click(object sender, EventArgs e)
        {
            mainForm = new MainForm();
            mainForm.SaveFileDialog(null, key, iv);
        }

        private void btnSaveEncryptedText_Click(object sender, EventArgs e)
        {
            mainForm = new MainForm();
            mainForm.SaveFileDialog(tbxEncryptedText.Text, null, null);
        }
    }
}
