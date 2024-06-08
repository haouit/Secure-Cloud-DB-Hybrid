using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Newtonsoft.Json.Linq;

namespace Porject_NT219
{
    public partial class Login : Form
    {
        private string tokentype;
        private string accesstoken;
        public string TokenType
        {
            get { return tokentype; }
            set { tokentype = value; }
        }

        public string AccessToken
        {
            get { return accesstoken; }
            set { accesstoken = value; }
        }

        public Login()
        {
            InitializeComponent();
        }

        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };

        private async void btn_signin_Click(object sender, EventArgs e)
        {
            string username = tb_usename.Text;
            string password = tb_password.Text;

            var formData = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            });

            HttpResponseMessage response = await httpClient.PostAsync("auth/token", formData);

            using (response)
            {
                if (response.IsSuccessStatusCode)
                {
                    var res = await response.Content.ReadAsStringAsync();
                    JObject jsonResponse = JObject.Parse(res);
                    if (jsonResponse["access_token"] != null)
                    {
                        tokentype = jsonResponse["token_type"].ToString();
                        accesstoken = jsonResponse["access_token"].ToString();
                    }
                    User user = new User(tokentype, accesstoken);
                    this.Hide();
                    user.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_repass_Click(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {

        }
    }
}
