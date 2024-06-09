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
using MongoDB.Driver;
using Microsoft.Extensions.Logging.Console.Internal;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using Newtonsoft.Json;
using MongoDB.Driver.Core.Authentication;

namespace NT219_FinalProject
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

        private readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri(@"http://localhost:3000/")
        };

        private async void btn_signin_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost:3000/api/user/login";
            string username = tb_usename.Text;
            string password = tb_password.Text;
            string body = "{\"username\": \"" + username + "\", \"password\": \"" + password + "\"}";

            StringContent content = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                // Handle successful response
                string result = await response.Content.ReadAsStringAsync();
                User user = new User(client);
                user.Show();
                MessageBox.Show(result);
                // Do something with the result
            }
            else
            {
                // Handle error response
                string error = await response.Content.ReadAsStringAsync();
                // Do something with the error
            }
        }

        private async void btn_signup_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost:3000/api/user/register";
            string username = tb_usename.Text;
            string password = tb_password.Text;
            string body = "{\"username\": \"" + username + "\", \"password\": \"" + password + "\"}";

            StringContent content = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                // Handle successful response
                string result = await response.Content.ReadAsStringAsync();
                User user = new User(client);
                user.Show();
                MessageBox.Show(result);
                // Do something with the result
            }
            else
            {
                // Handle error response
                string error = await response.Content.ReadAsStringAsync();
                // Do something with the error
            }
        }
    }
}
