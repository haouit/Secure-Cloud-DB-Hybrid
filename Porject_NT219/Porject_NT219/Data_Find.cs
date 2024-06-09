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
        }

        public List<DataResponse> Data { get; set; }

        public class DataResponse
        {
            [JsonProperty("from")]
            public string from { get; set; }

            [JsonProperty("name")]
            public string name { get; set; }

            [JsonProperty("message")]
            public string message { get; set; }
        }

        private void AddprogressbarFind(string name_user, string name, string message)
        {
            datafind data = new datafind(client, username);
            data.Setnameuser(name_user);
            data.Setname(name);
            data.Setmessage(message);
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

                //Xóa tất cả các controls trong flowLayoutPanel3
                flowLayoutPanel1.Controls.Clear();

                // Hiển thị dữ liệu mới từ phản hồi
                if (responseObject != null)
                {
                    foreach (var data_response in responseObject)
                    {
                        try
                        {
                            string from = data_response.from;
                            string name = data_response.name;
                            string message = data_response.message;
                            AddprogressbarFind(from, name, message);
                        }
                        catch { }
                    }
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {

        }

        private void btn_find_Click(object sender, EventArgs e)
        {

        }
    }
}
