using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NT219_FinalProject.Crypto;
using static NT219_FinalProject.User;

namespace NT219_FinalProject
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        byte[] data;
        byte[] secret_key;
        byte[] iv;

        private void button1_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            string fileName = "";
            // Open a file dialog
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = Path.GetFileName(ofd.FileName);

                // Read the file
                data = File.ReadAllBytes(ofd.FileName);
            }

            OpenFileDialog keyDialog = new OpenFileDialog();
            if (keyDialog.ShowDialog() == DialogResult.OK)
            {
                string keyFileName = Path.GetFileName(keyDialog.FileName);

                // Read the key file
                secret_key = File.ReadAllBytes(keyDialog.FileName);
            }

            OpenFileDialog ivDialog = new OpenFileDialog();
            if (ivDialog.ShowDialog() == DialogResult.OK)
            {
                string ivFileName = Path.GetFileName(ivDialog.FileName);

                // Read the key file
                iv = File.ReadAllBytes(ivDialog.FileName);
            }


            byte[] encrypted = aes.Encrypt(data, secret_key, iv);

            // Write the encrypted data to a file
            File.WriteAllBytes("enc." + fileName, encrypted);
            // Decrypt the data
            byte[] decrypted = aes.Decrypt(encrypted, secret_key, iv);
            // Write the decrypted data to a file 

            // Create the file if it doesn't exist
            if (!File.Exists("dec." + fileName))
            {
                File.Create("dec." + fileName).Close();
            }

            File.WriteAllBytes("dec." + fileName, decrypted);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
