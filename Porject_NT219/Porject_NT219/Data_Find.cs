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

namespace NT219_FinalProject
{
    public partial class Data_Find : Form
    {
        HttpClient client;
        public Data_Find(HttpClient Client)
        {
            InitializeComponent();
            client = Client;
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

        private void AddprogressbarAccept(string name_data, string name_user, string Id)
        {
            datafind data = new datafind(client);
            data.Setname(name_data);
            data.Setdataname(name_user);
            data.Setdataid(Id);
            flowLayoutPanel1.Controls.Add(data);
        }

        private async Task SendRequestFind()
        {
            flowLayoutPanel1.Controls.Clear();

            // Hiển thị dữ liệu mới từ phản hồi
            //foreach (var data_response in Response form cloud)
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
