using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NT219_FinalProject.Crypto;
using Microsoft.VisualBasic.ApplicationServices;
using System.Net.Http.Json;
using Microsoft.AspNetCore.WebUtilities;
using MongoDB.Driver;
using static NT219_FinalProject.User;

namespace NT219_FinalProject
{
    public partial class User : Form
    {
        const string BaseURL = Config.BaseURL;
        HttpClient client;
        string username;

        public User(HttpClient Client, string Username)
        {
            InitializeComponent();
            client = Client;
            username = Username;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel3.AutoScroll = true;
        }

        private void btn_newdata_Click(object sender, EventArgs e)
        {
            DataManager dataForm = new DataManager(client, username);
            dataForm.Show();
        }

        public List<DataResponse> Data { get; set; }

        public class DataResponse
        {
            [JsonProperty("from")]
            public string from { get; set; }

            [JsonProperty("to")]
            public string to { get; set; }

            [JsonProperty("message")]
            public string message { get; set; }

            [JsonProperty("status")]
            public string status { get; set; }
        }

        public List<FileResponse> file_sv { get; set; }

        public class FileResponse
        {
            [JsonProperty("author")]
            public string author { get; set; }

            [JsonProperty("filename")]
            public string filename { get; set; }

            [JsonProperty("content")]
            public string content { get; set; }
        }

        private void AddprogressbarData(string name_user, string filename, string message)
        {
            data_user data = new data_user(client, username);
            data.Setnameuser(name_user);
            data.Setfilename(filename);
            data.Setmessage(message);
            flowLayoutPanel1.Controls.Add(data);
        }

        private void AddprogressbarRequest(string name_user, string name_request, string message)
        {
            Request data = new Request(client, username);
            data.Setnameuser(name_user);
            data.Setnamerequest(name_request);
            data.Setmessage(message);
            flowLayoutPanel2.Controls.Add(data);
        }

        private void AddprogressbarAccpect(string name_user, string name_request, string message)
        {
            Accepted data = new Accepted(client, username);
            data.Setnameuser(name_user);
            data.Setnamerequest(name_request);
            data.Setmessage(message);
            flowLayoutPanel3.Controls.Add(data);
        }

        private async Task SendRequestData()
        {
            if (username == "") return;
            string url = $"{BaseURL}/api/data/all/{username}";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                List<FileResponse>? responseObject = JsonConvert.DeserializeObject<List<FileResponse>>(responseContent);

                //Xóa tất cả các controls trong flowLayoutPanel3
                flowLayoutPanel1.Controls.Clear();

                // Hiển thị dữ liệu mới từ phản hồi
                if (responseObject != null)
                {
                    foreach (var file_response in responseObject)
                    {
                        try
                        {
                            string author = file_response.author;
                            string filename = file_response.filename;
                            string content = file_response.content;
                            AddprogressbarData(author, filename, content);
                        }
                        catch { }
                    }
                }
            }
        }

        private async Task SendCheckRequest()
        {
            string url = $"{BaseURL}/api/communicate/check-requests/{username}";

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                // Response is a list of DataResponse
                string responseContent = await response.Content.ReadAsStringAsync();
                List<DataResponse>? responseObject = JsonConvert.DeserializeObject<List<DataResponse>>(responseContent);

                //Xóa tất cả các controls trong flowLayoutPanel3
                flowLayoutPanel2.Controls.Clear();

                if (responseObject != null)
                {
                    foreach (var data_response in responseObject)
                    {
                        try
                        {
                            string from = data_response.from;
                            string to = data_response.to;
                            string message = data_response.message;
                            string status = data_response.status;
                            AddprogressbarRequest(to, from, message);
                        }
                        catch { }
                    }
                }
            }
        }

        private async Task SendRequestAccept()
        {
            if (username == "") return;
            string url = $"{BaseURL}/api/communicate/check-responses";
            string body = "{\"from\": \"" + username + "\"}";
            StringContent content = new StringContent(body, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                List<DataResponse>? responseObject = JsonConvert.DeserializeObject<List<DataResponse>>(responseContent);

                //Xóa tất cả các controls trong flowLayoutPanel3
                flowLayoutPanel3.Controls.Clear();

                // Hiển thị dữ liệu mới từ phản hồi
                if (responseObject != null)
                {
                    foreach (var data_response in responseObject)
                    {
                        try
                        {
                            string from = data_response.from;
                            string to = data_response.to;
                            string message = data_response.message;
                            string status = data_response.status;

                            byte[] decryptedSecretKey = rsa.Decrypt(Convert.FromBase64String(message));
                            string decryptedSecretKeyBase64 = Convert.ToBase64String(decryptedSecretKey);

                            AddprogressbarAccpect(to, from, decryptedSecretKeyBase64);
                        }
                        catch { }
                    }
                }
            }
        }

        private async void btn_refresh_Click(object sender, EventArgs e)
        {
            await SendRequestData();
        }

        private async void btn_refreshrequest_Click(object sender, EventArgs e)
        {
            await SendCheckRequest();
        }

        private async void btn_refreshaccept_Click(object sender, EventArgs e)
        {
            await SendRequestAccept();
        }

        private static string rsaPublicKey;
        private static string rsaPrivateKey;
        string publicKeyFilePath;
        string privateKeyFilePath;
        RSA_Prj rsa = new RSA_Prj();

        private void btn_createpublickey_Click(object sender, EventArgs e)
        {
            rb_publickey.Clear();
            rb_privatekey.Clear();
            rsa.GenerateKeyPair();
            string[] keys = rsa.GetKeyPair();
            rsaPublicKey = keys[0];
            rsaPrivateKey = keys[1];
            rb_privatekey.Text = rsaPrivateKey;
            rb_publickey.Text = rsaPublicKey;
            checkBox1.Checked = true;
            checkBox3.Checked = true;
        }

        private void btn_loadprivate_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PEM Files (*.pem)|*.pem";
            openFileDialog.Title = "Select Private Key File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                privateKeyFilePath = openFileDialog.FileName;
                rsaPrivateKey = File.ReadAllText(privateKeyFilePath);
                rb_privatekey.Text = rsaPrivateKey;
                checkBox1.Checked = true;
                checkBox4.Checked = false;
            }
        }

        private void btn_loadpublic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PEM Files (*.pem)|*.pem";
            openFileDialog.Title = "Select Public Key File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                publicKeyFilePath = openFileDialog.FileName;
                rsaPublicKey = File.ReadAllText(publicKeyFilePath);
                rb_publickey.Text = rsaPublicKey;
                checkBox3.Checked = true;
                checkBox4.Checked = false;
            }
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked || !checkBox3.Checked || publicKeyFilePath == null || privateKeyFilePath == null)
            {
                MessageBox.Show("Please create or load a key pair first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            rsa.LoadKeyPair(publicKeyFilePath, privateKeyFilePath);
            checkBox4.Checked = true;
        }

        private void btn_saveprivatekey_Click(object sender, EventArgs e)
        {
            // Open folder browser dialog to select the file directory
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    rsa.SaveKeyPair(selectedPath + "/publickey.pem", selectedPath + "/privatekey.pem");
                    checkBox2.Checked = true;
                }
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            Data_Find data = new Data_Find(client, username);
            data.Show();
        }
    }
}
