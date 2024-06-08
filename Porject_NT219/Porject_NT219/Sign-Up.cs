using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace NT219_FinalProject
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private async void btn_signup_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://nt106.uitiot.vn/api/v1/user/signup";

            var userData = new
            {
                username = tb_username.Text,
                password = tb_password.Text
            };

            string jsonData = JsonConvert.SerializeObject(userData);


            using (var httpClient = new HttpClient())
            {
                try
                {
                    // Tạo nội dung yêu cầu từ chuỗi JSON
                    var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");

                    // Thực hiện yêu cầu POST
                    var response = await httpClient.PostAsync(apiUrl, content);

                    // Đọc nội dung phản hồi
                    string responseContent = await response.Content.ReadAsStringAsync();

                    // Hiển thị mã phản hồi và nội dung phản hồi
                    Console.WriteLine($"HTTP Status Code: {response.StatusCode}");
                    Console.WriteLine($"Response Content: {responseContent}");
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

        }
    }
}
