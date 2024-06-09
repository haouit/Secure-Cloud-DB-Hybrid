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
using MongoDB.Bson;

namespace NT219_FinalProject
{
    public partial class Login : Form
    {
        const string BaseURL = Config.BaseURL;
        private MongoClient clientmongo;

        public Login()
        {
            InitializeComponent();
            clientmongo = Login_Mongo();
        }

        private async void btn_signin_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = $"{BaseURL}/api/user/login";
            string username = tb_usename.Text;
            string password = tb_password.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password");
                return;
            }
            string body = "{\"username\": \"" + username + "\", \"password\": \"" + password + "\"}";

            StringContent content = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                // Handle successful response
                string result = await response.Content.ReadAsStringAsync();
                User user = new User(client, username, clientmongo);
                user.Show();
            }
            else
            {
                // Handle error response
                string error = await response.Content.ReadAsStringAsync();
                // Do something with the error
                MessageBox.Show(error);
            }
        }

        private async void btn_signup_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = $"{BaseURL}/api/user/register";
            string username = tb_usename.Text;
            string password = tb_password.Text;
            string body = "{\"username\": \"" + username + "\", \"password\": \"" + password + "\", \"email\": \"" + $"{username}@g,com" + "\"}";

            StringContent content = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                // Handle successful response
                string result = await response.Content.ReadAsStringAsync();
                User user = new User(client, username, clientmongo);
                user.Show();
                // Do something with the result
            }
            else
            {
                // Handle error response
                string error = await response.Content.ReadAsStringAsync();
                // Do something with the error
                MessageBox.Show(error);
            }
        }

        private MongoClient Login_Mongo()
        {
            string connectionUri = $"mongodb+srv://d0905206126:cde4Vht02d8YXni4@nt219.aqc0g5i.mongodb.net/?retryWrites=true&w=majority&appName=NT219";
            var settings = MongoClientSettings.FromConnectionString(connectionUri);

            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var clientmongo = new MongoClient(settings);

            try
            {
                var result = clientmongo.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return clientmongo;
        }
    }
}
