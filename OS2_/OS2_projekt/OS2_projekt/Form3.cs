using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using static System.Console;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Crypto.Engines;

namespace OS2_projekt
{
    public partial class Form3 : Form
    {
        private static byte[] IV = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        public static byte[] tmpSource;
        public Form3() 
        {
            InitializeComponent();
        }
        static string byteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for(i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X").ToLower());
            }
            return sOutput.ToString();
        }
        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = ofd.FileName;
            }

            string[] lines = File.ReadAllLines(ofd.FileName);

            for (int i = 0; i < lines.Length; i++)
            {
                plainTextBox2.Text = lines[i];
            }
        }
        public string Encrypt(string plainText, string password, byte[] IV)
        {

            byte[] key = Encoding.UTF8.GetBytes(password);

            AesManaged aes = new AesManaged();

            aes.Key = key;
            aes.IV = IV;

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);
            cs.Write(inputBytes, 0, inputBytes.Length);
            cs.FlushFinalBlock();

            byte[] encrypted = ms.ToArray();

            return Convert.ToBase64String(encrypted);
        }

        public string Decrypt(string plainText, string password, byte[] IV)
        {
            byte[] key = Encoding.UTF8.GetBytes(password);

            AesManaged aes = new AesManaged();
            aes.Key = key;
            aes.IV = IV;

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write);

            byte[] inputBytes = Convert.FromBase64String(plainText);
            cs.Write(inputBytes, 0, inputBytes.Length);
            cs.FlushFinalBlock();

            byte[] decrypted = ms.ToArray();
            return UTF8Encoding.UTF8.GetString(decrypted, 0, decrypted.Length);

        }
        private void symetricAlgorithms_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show(symetricAlgorithms.SelectedItem.ToString());
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
        private void encryptButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                beforeTextBox2.Text = Encrypt(plainTextBox2.Text, passwordTextBox.Text, IV);
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(baseDirectory, "OS2_moje", "Simetricni_kriptirani_tekst.txt");
                StreamWriter sw = new StreamWriter(filePath);
                sw.Write(beforeTextBox2.Text);
                sw.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void decryptButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                symDecryptTextBox.Text = Decrypt(afterTextBox2.Text, chosenPasswordTextBox.Text, IV);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openDecryptButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = ofd.FileName;
            }

            string[] lines = File.ReadAllLines(ofd.FileName);

            for (int i = 0; i < lines.Length; i++)
            {
                afterTextBox2.Text = lines[i];
            }
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void choosePasswordButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(ofd.FileName);

                for (int i = 0; i < lines.Length; i++)
                {
                    chosenPasswordTextBox.Text = lines[i];
                }
            }
        }

        private void confirmPasswordButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(ofd.FileName);

                for (int i = 0; i < lines.Length; i++)
                {
                    passwordTextBox.Text = lines[i];
                }
            }
        }
        string getSHA(string input)
        {
            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
        private void calculateHashButton_Click(object sender, EventArgs e)
        {
            hashTextBox2.Text = getSHA(plainTextBox2.Text);

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(baseDirectory, "OS2_moje", "simetricni_sazetak.txt");
            StreamWriter sw = new StreamWriter(filePath);
            sw.Write(hashTextBox2.Text);
            sw.Close();
        }

        private void generatePassword_Click(object sender, EventArgs e)
        {
            var chars = "abcdefghijklmnoprstquvwxyz0123456789";
            string password = "";
            Random ran = new Random();
            for (int i = 0; i < 16; i++)
            {
                password += chars[ran.Next(chars.Length)];
            }
            MessageBox.Show("Generiran je novi tajni kljuc");

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(baseDirectory, "OS2_moje", "tajni_kljuc.txt");
            StreamWriter sw = new StreamWriter(filePath);
            sw.Write(password);
            sw.Close();
        }
    }
}
