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
        HttpClient client;

        public User(HttpClient Client)
        {
            InitializeComponent();
            client = Client;
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
            string url = $"http://localhost:3000/api/communicate/";
            string body = "{\"username\": \"hao\", \"password\": \"123\"}";

            StringContent content = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);

            HttpResponseMessage responses = null;

            if (responses.IsSuccessStatusCode)
            {
                string responseContent = await responses.Content.ReadAsStringAsync();
                DataResponse responseObject = JsonConvert.DeserializeObject<DataResponse>(responseContent);

                // Xóa tất cả các controls trong flowLayoutPanel1
                flowLayoutPanel1.Controls.Clear();

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

            HttpResponseMessage responses = null;

            if (responses.IsSuccessStatusCode)
            {
                string responseContent = await responses.Content.ReadAsStringAsync();
                DataResponse responseObject = JsonConvert.DeserializeObject<DataResponse>(responseContent);

                // Xóa tất cả các controls trong flowLayoutPanel1
                flowLayoutPanel1.Controls.Clear();

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
            string id = "data_response.Id";
            string data_name = "data_response.name_data";
            string user_name = "data_response.name_user";
            AddprogressbarData(id, data_name, user_name);
        }

        private void btn_refreshrequest_Click(object sender, EventArgs e)
        {
            string id = "data_response.Id";
            string data_name = "data_response.name_data";
            string user_name = "data_response.name_user";
            AddprogressbarRequest(id, data_name, user_name);
        }

        private void btn_refreshaccept_Click(object sender, EventArgs e)
        {
            string id = "data_response.Id";
            string data_name = "data_response.name_data";
            string user_name = "data_response.name_user";
            AddprogressbarAccept(id, data_name, user_name);
        }

        private static byte[] rsaPublicKey;
        private static byte[] rsaPrivateKey;

        private void btn_createpublickey_Click(object sender, EventArgs e)
        {
            rb_publickey.Clear();
            rb_privatekey.Clear();
            //byte[][] pubandpri = rsa.GenerateKeyPair();
            //rsaPublicKey = pubandpri[0];
            //rsaPrivateKey = pubandpri[1];

            RSA_Prj rsa = new RSA_Prj();
            rsa.GenerateKeyPair();
            string[] keys = rsa.GetKeyPair();
            rb_privatekey.Text = Convert.ToBase64String(rsaPrivateKey);
            rb_publickey.Text = Convert.ToBase64String(rsaPublicKey);
        }

        private void btn_configpublickey_Click(object sender, EventArgs e)
        {

        }

        private void btn_saveprivatekey_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllBytes(fileName + "public_key.bin", rsaPublicKey);
                File.WriteAllBytes(fileName + "private_key.bin", rsaPrivateKey);
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            Data_Find df = new Data_Find();
            df.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
