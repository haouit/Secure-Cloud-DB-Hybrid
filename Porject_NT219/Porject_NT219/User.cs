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


namespace NT219_FinalProject
{
    public partial class User : Form
    {
        const string BaseURL = "http://localhost:3000";
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

        private void AddprogressbarData(string name_data, string name_user, string Id)
        {
            data_user data = new data_user();
            data.Setname(name_data);
            data.Setdataname(name_user);
            data.Setdataid(Id);
            flowLayoutPanel1.Controls.Add(data);
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
                        }
                        catch { }
                    }
                }
            }
        }

        private async Task SendRequestAccept()
        {

            string url = $"{BaseURL}/api/communicate/check-response";
            string body = "{\"from\": \"" + username + "\"}";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                DataResponse responseObject = JsonConvert.DeserializeObject<DataResponse>(responseContent);

                // Xóa tất cả các controls trong flowLayoutPanel1
                flowLayoutPanel3.Controls.Clear();

                //// Hiển thị dữ liệu mới từ phản hồi
                //foreach (var data_response in responseObject.Data)
                //{
                //    try
                //    {
                //        string id = data_response.Id;
                //        string data_name = data_response.name_data;
                //        string user_name = data_response.name_user;
                //        // Thêm Hienthimonan vào flowLayoutPanel1 với các giá trị tương ứng
                //        AddprogressbarAccept(id, data_name, user_name);
                //    }
                //    catch { }
                //}
            }
        }

        private async void btn_refresh_Click(object sender, EventArgs e)
        {
            await SendCheckRequest();
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
        }

        private void btn_configpublickey_Click(object sender, EventArgs e)
        {
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
    }
}
