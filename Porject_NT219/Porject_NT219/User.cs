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
using static NT219_FinalProject.User;


namespace NT219_FinalProject
{
    public partial class User : Form
    {
        const string RootURI = "http://localhost:3000";
        HttpClient client;
        string username;

        public User(HttpClient Client, string Username)
        {
            InitializeComponent();
            client = Client;
            username = Username;
        }

        private void btn_newdata_Click(object sender, EventArgs e)
        {
            DataManager dataForm = new DataManager();
            dataForm.Show();
        }

        private void btn_downdata_Click(object sender, EventArgs e)
        {
            //request data from cloud

        }

        public class DataResponse
        {
            public List<Data_response> Data { get; set; }
        }

        public class Data_response
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name_data")]
            public string name_data { get; set; }

            [JsonProperty("name_user")]
            public string name_user { get; set; }
        }

        private void AddprogressbarData(string name_data, string name_user, string Id)
        {
            data_user data = new data_user();
            data.Setname(name_data);
            data.Setdataname(name_user);
            data.Setdataid(Id);
            flowLayoutPanel1.Controls.Add(data);
        }

        private void AddprogressbarRequest(string name_data, string name_user, string Id)
        {
            Request data = new Request(client);
            data.Setname(name_data);
            data.Setdataname(name_user);
            data.Setdataid(Id);
            flowLayoutPanel2.Controls.Add(data);
        }

        private void AddprogressbarAccept(string name_data, string name_user, string Id)
        {
            Accepted data = new Accepted();
            data.Setname(name_data);
            data.Setdataname(name_user);
            data.Setdataid(Id);
            flowLayoutPanel3.Controls.Add(data);
        }

        private async Task SendRequestRequest()
        {
            string url = $"{RootURI}/api/communicate/check-requests/{username}";

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                DataResponse responseObject = JsonConvert.DeserializeObject<DataResponse>(responseContent);

                // Xóa tất cả các controls trong flowLayoutPanel1
                flowLayoutPanel2.Controls.Clear();

                // Hiển thị dữ liệu mới từ phản hồi
                foreach (var data_response in responseObject.Data)
                {
                    try
                    {
                        string id = data_response.Id;
                        string data_name = data_response.name_data;
                        string user_name = data_response.name_user;
                        // Thêm Hienthimonan vào flowLayoutPanel1 với các giá trị tương ứng
                        AddprogressbarRequest(id, data_name, user_name);
                    }
                    catch { }
                }
            }
        }

        private async Task SendRequestAccept()
        {

            string url = $"{RootURI}/api/communicate/check-resopnse";
            string body = "{\"fron\": \"" + username + "\"}";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                DataResponse responseObject = JsonConvert.DeserializeObject<DataResponse>(responseContent);

                // Xóa tất cả các controls trong flowLayoutPanel1
                flowLayoutPanel3.Controls.Clear();

                // Hiển thị dữ liệu mới từ phản hồi
                foreach (var data_response in responseObject.Data)
                {
                    try
                    {
                        string id = data_response.Id;
                        string data_name = data_response.name_data;
                        string user_name = data_response.name_user;
                        // Thêm Hienthimonan vào flowLayoutPanel1 với các giá trị tương ứng
                        AddprogressbarAccept(id, data_name, user_name);
                    }
                    catch { }
                }
            }
        }

        private async void btn_refresh_Click(object sender, EventArgs e)
        {
            //pull cloud
        }

        private void btn_refreshrequest_Click(object sender, EventArgs e)
        {
            SendRequestRequest();
        }

        private void btn_refreshaccept_Click(object sender, EventArgs e)
        {
            SendRequestAccept();
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
            if (!checkBox1.Checked || !checkBox3.Checked)
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
            Data_Find df = new Data_Find(client);
            df.Show();
        }
    }
}
