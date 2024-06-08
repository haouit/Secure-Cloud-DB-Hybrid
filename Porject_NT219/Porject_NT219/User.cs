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

namespace NT219_FinalProject
{
    public partial class User : Form
    {
        private string receivedUserid;
        private string receivedAccessToken;
        List<string> thongtin = new List<string>();

        public User(string userid, string accesstoken)
        {
            InitializeComponent();
            receivedUserid = userid;
            receivedAccessToken = accesstoken;
        }
        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };

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

        private void Addprogressbar(string name_data, string name_user, string Id)
        {
            Request data = new Request();
            data.Setname(name_data);
            data.Setdataname(name_user);
            data.Setdataid(Id);
            flowLayoutPanel1.Controls.Add(data);
        }

        private async Task SendRequestByme(int currentPage, int pageSize)
        {
            string apiUrl = "https://nt106.uitiot.vn/api/v1/monan/my-dishes";
            var requestData = new
            {
                current = currentPage,
                pageSize = pageSize,
            };

            string jsonData = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Gửi yêu cầu POST đến API và nhận phản hồi
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
            request.Content = content;
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(receivedUserid, receivedAccessToken);

            HttpResponseMessage responses = await httpClient.SendAsync(request);

            if (responses.IsSuccessStatusCode)
            {
                string responseContent = await responses.Content.ReadAsStringAsync();
                DataResponse responseObject = JsonConvert.DeserializeObject<DataResponse>(responseContent);

                // Xóa tất cả các controls trong flowLayoutPanel1
                flowLayoutPanel1.Controls.Clear();
                thongtin.Clear();

                // Hiển thị dữ liệu mới từ phản hồi
                foreach (var data_response in responseObject.Data)
                {
                    try
                    {
                        string id = data_response.Id;
                        string data_name = data_response.name_data;
                        string user_name = data_response.name_user;
                        string information = id + "," + data_name + "," + user_name + ";";
                        thongtin.Add(information);
                        // Thêm Hienthimonan vào flowLayoutPanel1 với các giá trị tương ứng
                        Addprogressbar(id, data_name, user_name);
                    }
                    catch { }
                }
            }
        }

        private void btn_newdata_Click(object sender, EventArgs e)
        {
            DataManager dataForm = new DataManager();
            dataForm.Show();
        }

        private void btn_downdata_Click(object sender, EventArgs e)
        {
            //request data from server

        }

        private async void btn_refresh_Click(object sender, EventArgs e)
        {

            //await SendRequestByme(currentPage, pageSize);
        }

        private static byte[] rsaPublicKey;
        private static byte[] rsaPrivateKey;

        private void btn_createpublickey_Click(object sender, EventArgs e)
        {
            rb_publickey.Clear();
            rb_privatekey.Clear();
            RSA rsa = new RSA();
            byte[][] pubandpri = rsa.GenerateKeyPair();
            rsaPublicKey = pubandpri[0];
            rsaPrivateKey = pubandpri[1];
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
    }
}
