using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Mvc;
using static NT219_FinalProject.User;
using Newtonsoft.Json;
using static NT219_FinalProject.Data_Find;
using MongoDB.Driver.Core.Authentication;
using MongoDB.Driver;

namespace NT219_FinalProject
{
    public partial class Data_Find : Form
    {
        HttpClient client;
        string username;
        const string BaseURL = Config.BaseURL;

        public Data_Find(HttpClient Client, string Username)
        {
            InitializeComponent();
            client = Client;
            username = Username;
            flowLayoutPanel1.AutoScroll = true;
        }

        public List<DataResponse> Data { get; set; }

        public class DataResponse
        {
            [JsonProperty("author")]
            public string author { get; set; }

            [JsonProperty("filename")]
            public string filename { get; set; }

            [JsonProperty("content")]
            public string content { get; set; }
        }

        private void AddprogressbarFind(string author, string filename, string content)
        {
            datafind data = new datafind(client, username);
            data.Setnameuser(author);
            data.Setfilename(filename);
            data.Setmessage(content);
            flowLayoutPanel1.Controls.Add(data);
        }

        private async Task SendRequestFind()
        {
            if (username == "") return;

            string url = $"{BaseURL}/api/data/all/{tb_find.Text}";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                List<DataResponse>? responseObject = JsonConvert.DeserializeObject<List<DataResponse>>(responseContent);

                //Xóa tất cả các controls trong flowLayoutPanel1
                flowLayoutPanel1.Controls.Clear();

                // Hiển thị dữ liệu mới từ phản hồi
                if (responseObject != null)
                {
                    foreach (var data_response in responseObject)
                    {
                        try
                        {
                            string author = data_response.author;
                            string filename = data_response.filename;
                            string content = data_response.content;
                            AddprogressbarFind(author, filename, content);
                        }
                        catch { }
                    }
                }
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            SendRequestFind();
        }
    }
}
