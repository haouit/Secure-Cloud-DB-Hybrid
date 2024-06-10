using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NT219_FinalProject.User;
using Newtonsoft.Json;
using NT219_FinalProject.Crypto;
using SharpCompress.Common;

namespace NT219_FinalProject
{
    public partial class Download : Form
    {
        const string BaseURL = Config.BaseURL;
        HttpClient client;
        string username;
        string key;
        string author;
        public Download(HttpClient Client, string Username, string Key, string Author)
        {
            InitializeComponent();
            client = Client;
            username = Username;
            key = Key;
            author = Author;
            flowLayoutPanel1.AutoScroll = true;
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
            Down_file data = new Down_file();
            data.Setnameuser(name_user);
            data.Setfilename(filename);
            data.Setmessage(message);
            flowLayoutPanel1.Controls.Add(data);
        }

        private async Task SendRequestData()
        {
            string url = $"{BaseURL}/api/data/all/{author}";
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

                            AES_Prj aes = new AES_Prj();
                            byte[] encryptedData = Convert.FromBase64String(content);
                            byte[] secretKeyIV = Convert.FromBase64String(key);
                            byte[] secretKey = new byte[32];
                            byte[] secretIV = new byte[16];

                            File.WriteAllBytes("aaaaaa.bin", secretKey);

                            Array.Copy(secretKeyIV, 0, secretKey, 0, 32);
                            Array.Copy(secretKeyIV, 32, secretIV, 0, 16);

                            byte[] decryptedData = aes.Decrypt(encryptedData, secretKey, secretIV);

                            AddprogressbarData(author, filename, content);
                        }
                        catch { }
                    }
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            SendRequestData();
        }
    }
}
