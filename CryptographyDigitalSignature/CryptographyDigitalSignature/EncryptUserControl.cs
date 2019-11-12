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

        private MainForm mainForm;
        readonly AesAlgorithm aesAlg = new AesAlgorithm();
        readonly RsaAlgorithm rsaAlg = new RsaAlgorithm();

        string plainText = string.Empty;
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = tbxPlainText.Text;
            if(plainText == string.Empty)
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
            tbxPlainText.Text = string.Empty;
            tbxEncryptedText.Text = string.Empty;
            mainForm = new MainForm();
            plainText = mainForm.OpenFileDialog();
            if(mainForm.path != string.Empty)
            {
                lblChosenFile.Text = "Path: " + mainForm.path;
            }
            tbxPlainText.Text = plainText;
        }

        private void btnSaveSecretKey_Click(object sender, EventArgs e)
        {
            mainForm = new MainForm();
            if(key != null && iv != null)
            {
                mainForm.SaveFileDialog(key, iv);
            }
            else
            {
                MessageBox.Show("Text is not encrypted successfully. Try again!", "Error");
            }
        }

        private void btnSaveEncryptedText_Click(object sender, EventArgs e)
        {
            string encryptedText = tbxEncryptedText.Text;
            mainForm = new MainForm();
            if(encryptedText != string.Empty)
            {
                mainForm.SaveFileDialog(tbxEncryptedText.Text);
            }
            else
            {
                MessageBox.Show("Text is not encrypted successfully. Try again!", "Error");
            }
        }
    }
}
