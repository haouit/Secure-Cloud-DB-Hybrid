using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using NT219_FinalProject.Crypto;
using System.Security.Cryptography;

namespace NT219_FinalProject
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            byte[] data = null;
            byte[] secret_key = null;
            byte[] iv = null;
            AES_Prj aes = new AES_Prj();
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
            RSA_Prj rsa = new RSA_Prj();
            rsa.GenerateKeyPair();
            string[] keys = rsa.GetKeyPair();

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //fileName = Path.GetFileName(ofd.FileName);

                //// Read the file
                //data = File.ReadAllBytes(ofd.FileName);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost:3000/api/user/login";
            string body = "{\"username\": \"hao\", \"password\": \"123\"}";

            StringContent content = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                // Handle successful response
                string result = await response.Content.ReadAsStringAsync();
                MessageBox.Show(result);
                // Do something with the result
            }
            else
            {
                // Handle error response
                string error = await response.Content.ReadAsStringAsync();
                // Do something with the error
            }
        }
    }
}
