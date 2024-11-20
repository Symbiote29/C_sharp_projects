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
using ExpressEncription;
using System.Xml.Serialization;

namespace OS2_projekt
{
    public partial class Form2 : Form
    {
        UnicodeEncoding encoding = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] plainText;

        public Form2()
        {
            InitializeComponent();
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
                plainTextBox.Text = lines[i];
            }
        }

        public static byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void asymetricAlgorithms_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show(asymetricAlgorithms.SelectedItem.ToString());
        }

        private void encryptButton_Click_1(object sender, EventArgs e)
        {
            if(plainTextBox.Text == "")
            {
                MessageBox.Show("Nema teksta za kriptiranje");
            }
            else
            {
                try
                {
                    RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                    RSA.FromXmlString(publicKeyTextBox.Text);
                    byte[] decrypted = System.Text.Encoding.Unicode.GetBytes(plainTextBox.Text);

                    plainText = encoding.GetBytes(plainTextBox.Text);
                    byte[] encrypted = Encryption(plainText, RSA.ExportParameters(false), false);
                    beforeTextBox.Text = System.Convert.ToBase64String(encrypted);

                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string filePath = Path.Combine(baseDirectory, "OS2_moje", "Asimetricni_kriptirani_tekst.txt");
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Write(beforeTextBox.Text);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void decryptButton_Click_1(object sender, EventArgs e)
        {
            if (afterTextBox.Text == "")
            {
                MessageBox.Show("Nema teksta za dekriptirati");
            }
            else
            {
                CspParameters cspParam = new CspParameters();
                cspParam.Flags = CspProviderFlags.UseMachineKeyStore;
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                RSA.FromXmlString(privateKeyTextBox.Text);
                byte[] encrypted = System.Convert.FromBase64String(afterTextBox.Text);

                byte[] decrypted = Decryption(encrypted, RSA.ExportParameters(true), false);
                decryptedTextBox.Text = System.Text.Encoding.Unicode.GetString(decrypted);
            }
        }

        private void uploadDecryptButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = ofd.FileName;
            }

            string[] lines = File.ReadAllLines(ofd.FileName);

            for (int i = 0; i < lines.Length; i++)
            {
                afterTextBox.Text = lines[i];
            }
        }

        string getSHA(string input)
        {
            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sb = new StringBuilder();
            for(int i = 0; i< bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
        private void calculateHashButton2_Click(object sender, EventArgs e)
        {
            hashTextBox2.Text = getSHA(plainTextBox.Text);

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(baseDirectory, "OS2_moje", "asimetricni_sazetak.txt");
            StreamWriter sw = new StreamWriter(filePath);
            sw.Write(hashTextBox2.Text);
            sw.Close();
        }

        private void uploadButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = ofd.FileName;
            }

            string[] lines = File.ReadAllLines(ofd.FileName);

            for (int i = 0; i < lines.Length; i++)
            {
                checkTextBox.Text = lines[i];
            }
        }
        public static byte[] HashAndSignBytes(byte[] DataToSign, RSAParameters Key)
        {
            try
            {
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();
                RSAalg.ImportParameters(Key);

                return RSAalg.SignData(DataToSign, SHA256.Create());
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }
        public static bool VerifySignedHash(byte[] DataToVerify, byte[] SignedData, RSAParameters Key)
        {
            try
            {
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();
                RSAalg.ImportParameters(Key);

                return RSAalg.VerifyData(DataToVerify, SHA256.Create(), SignedData);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return false;
            }
        }
        private void signButton_Click(object sender, EventArgs e)
        {
            try
            {
                signedTextBox.Text = Cryptography.RSASignWithPEMPrivateKey(textBox1.Text, checkTextBox.Text);

                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(baseDirectory, "OS2_moje", "digitalni_potpis.txt");
                StreamWriter sw = new StreamWriter(filePath);
                sw.Write(signedTextBox.Text);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Signing Error");
            }
        }

        private void uploadButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = ofd.FileName;
            }

            string[] lines = File.ReadAllLines(ofd.FileName);

            for (int i = 0; i < lines.Length; i++)
            {
                signatureTextBox.Text = lines[i];

            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = Cryptography.VerifySignature(chosenPublicKeyTextBox.Text, digitalTextBox.Text, signatureTextBox.Text);
                string output = result ? "The signature matches" : "The signature doesnt match";
                MessageBox.Show(output, result ? "Success" : "Error");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void generateKeysButton_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
            RSAParameters _privateKey = csp.ExportParameters(true);
            RSAParameters _publicKey = csp.ExportParameters(false);

            var str = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(str, _publicKey);

            var str1 = new StringWriter();
            var xs1 = new XmlSerializer(typeof(RSAParameters));
            xs1.Serialize(str1, _privateKey);

            publicKeyTextBox.Text = str.ToString();
            privateKeyTextBox.Text = str1.ToString();

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(baseDirectory, "OS2_moje", "javni_kljuc.txt");
            StreamWriter sw = new StreamWriter(filePath);
            sw.Write(str.ToString());
            sw.Close();

            string baseDirectory2 = AppDomain.CurrentDomain.BaseDirectory;
            string filePath2 = Path.Combine(baseDirectory, "OS2_moje", "privatni_kljuc.txt");
            StreamWriter sw2 = new StreamWriter(filePath);
            sw2.Write(str1.ToString());
            sw2.Close();
            
        }

        private void privateKeyButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PEM files(*.PEM) | *.PEM";
            DialogResult result = ofd.ShowDialog();
            if(result == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void choosePublicKeyButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PEM files(*.PEM) | *.PEM";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                chosenPublicKeyTextBox.Text = ofd.FileName;
            }
        }

        private void inputStringTextBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = ofd.FileName;
            }

            string[] lines = File.ReadAllLines(ofd.FileName);

            for (int i = 0; i < lines.Length; i++)
            {
                digitalTextBox.Text = lines[i];
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
