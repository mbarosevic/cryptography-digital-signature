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
            cbxEncryptionAlgorithm.SelectedIndex = 0;
        }
        MainForm mainForm;
        AesAlgorithm aesAlg = new AesAlgorithm();

        string plainText = string.Empty;
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
        private string key = string.Empty;
        private string iv = string.Empty;
        public void Encrypt(string plainText)
        {
            using(Aes aes = Aes.Create())
            {
                byte[] encrypted = aesAlg.EncryptToByteArray(plainText, aes.Key, aes.IV);
                tbxEncryptedText.Text = Convert.ToBase64String(encrypted);
                key = Convert.ToBase64String(aes.Key);
                iv = Convert.ToBase64String(aes.IV);
            }
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            tbxPlainText.Text = "";
            tbxEncryptedText.Text = "";
            mainForm = new MainForm();
            plainText = mainForm.OpenFileDialog();
            tbxPlainText.Text = plainText;
        }

        private void btnSaveSecretKey_Click(object sender, EventArgs e)
        {
            mainForm = new MainForm();
            using(Aes aes = Aes.Create())
            {
                mainForm.SaveFileDialog(key, iv);
            }
        }
    }
}
