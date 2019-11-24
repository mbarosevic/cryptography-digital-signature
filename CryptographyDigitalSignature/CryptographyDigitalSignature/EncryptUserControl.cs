using System;
using System.Windows.Forms;
using System.Security.Cryptography;

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

        readonly AesAlgorithm aesAlg = new AesAlgorithm();
        readonly RsaAlgorithm rsaAlg = new RsaAlgorithm();
        string plainText = string.Empty;
        private byte[] encryptedText;

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = tbxPlainText.Text;
            if(string.IsNullOrEmpty(plainText))
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
                    byte[] plainTextToEncrypt;
                    plainTextToEncrypt = rsaAlg.ByteConverter.GetBytes(tbxPlainText.Text);
                    encryptedText = rsaAlg.Encryption(plainTextToEncrypt, rsaAlg.RSA.ExportParameters(false), false);
                    if(encryptedText != null)
                    {
                        //tbxEncryptedText.Text = rsaAlg.ByteConverter.GetString(encryptedText);
                        tbxEncryptedText.Text = Convert.ToBase64String(encryptedText);
                    }
                    else
                    {
                        MessageBox.Show("Sorry, can't encrypt given text.");
                    }
                }
            }
        }

        public string Decrypt()
        {
            byte[] decryptedtex = rsaAlg.Decryption(encryptedText,
            rsaAlg.RSA.ExportParameters(true), false);
            string s = rsaAlg.ByteConverter.GetString(decryptedtex);
            return s;
        }
        private string key = string.Empty;
        private string iv = string.Empty;

        public MainForm MainForm { get => MainForm; set => MainForm = value; }

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
            MainForm = new MainForm();
            plainText = MainForm.OpenFileDialog();
            if(!string.IsNullOrEmpty(MainForm.path))
            {
                lblChosenFile.Text = "Path: " + MainForm.path;
            }
            tbxPlainText.Text = plainText;
        }

        private void btnSaveSecretKey_Click(object sender, EventArgs e)
        {
            MainForm = new MainForm();
            if(key != null && iv != null)
            {
                MainForm.SaveFileDialog(key, iv);
            }
            else
            {
                MessageBox.Show("Text is not encrypted successfully. Try again!", "Error");
            }
        }

        private void btnSaveEncryptedText_Click(object sender, EventArgs e)
        {
            string encryptedText = tbxEncryptedText.Text;
            MainForm = new MainForm();
            if(!string.IsNullOrEmpty(encryptedText))
            {
                MainForm.SaveFileDialog(tbxEncryptedText.Text);
            }
            else
            {
                MessageBox.Show("Text is not encrypted successfully. Try again!", "Error");
            }
        }
    }
}
