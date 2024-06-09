using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using NT219_FinalProject.Crypto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NT219_FinalProject
{
    public partial class DataManager : Form
    {
        string username;
        HttpClient client;
        const string BaseURL = Config.BaseURL;

        public DataManager(HttpClient Client, string Username)
        {
            InitializeComponent();
            client = Client;
            username = Username;
        }

        byte[] data;
        byte[] secret_key;
        byte[] iv;

        private void btn_dataload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                data = File.ReadAllBytes(openFileDialog.FileName);
                checkBox1.Checked = true;
                lb_namefile.Text = openFileDialog.SafeFileName;

            }
        }

        private void btn_loadkey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                secret_key = File.ReadAllBytes(openFileDialog.FileName);
                checkBox2.Checked = true;
                lb_namekey.Text = openFileDialog.SafeFileName;
            }
        }

        private void btn_loadiv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                iv = File.ReadAllBytes(openFileDialog.FileName);
                checkBox3.Checked = true;
                lb_nameiv.Text = openFileDialog.SafeFileName;
            }
        }

        private async void btn_uploaddata_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked || !checkBox2.Checked || !checkBox3.Checked)
            {
                MessageBox.Show("Please load data, key and iv");
                return;
            }

            //upload to server
            AES_Prj aes = new AES_Prj();
            string fileName = lb_namefile.Text;
            byte[] encryptedData = aes.Encrypt(data, secret_key, iv);
            string data_send = Convert.ToBase64String(encryptedData);
            string url = $"{BaseURL}/api/data/upload-data";
            string body = "{\"author\": \"" + username + "\", \"filename\": \"" + fileName + "\", \"content\": \"" + data_send + "\"}";
            StringContent content = new StringContent(body, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                // Handle successful response
                string result = await response.Content.ReadAsStringAsync();
                // Do something with the result
            }
            else
            {
                // Handle error response
                string error = await response.Content.ReadAsStringAsync();
                // Do something with the error
            }

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            data = null;
            secret_key = null;
            iv = null;
            lb_namefile.Text = "Name file";
            lb_namekey.Text = "Name file";
            lb_nameiv.Text = "Name file";
            this.Hide();
            this.Close();
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            AES_Prj aes = new AES_Prj();
            byte[][] keyAndIV = aes.KeyIVGen();
            secret_key = keyAndIV[0];
            iv = keyAndIV[1];

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllBytes(fileName + "_key.bin", secret_key);
                File.WriteAllBytes(fileName + "_iv.bin", iv);
            }
            checkBox2.Checked = true;
            checkBox3.Checked = true;
        }
    }
}