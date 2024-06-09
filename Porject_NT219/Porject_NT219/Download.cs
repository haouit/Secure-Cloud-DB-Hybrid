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

namespace NT219_FinalProject
{
    public partial class Download : Form
    {
        const string BaseURL = Config.BaseURL;
        HttpClient client;
        string username;
        string key;
        public Download(HttpClient Client, string Username, string Key)
        {
            InitializeComponent();
            client = Client;
            username = Username;
            key = Key;

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
                            /// dec here with key
                            
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
