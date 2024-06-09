using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT219_FinalProject
{
    public partial class datafind : UserControl
    {
        const string BaseURL = Config.BaseURL;
        HttpClient client;
        string username;
        public datafind(HttpClient Client, string Username)
        {
            InitializeComponent();
            client = Client;
            username = Username;
        }

        public void Setnamerequest(string s)
        {
            lb_namerequest.Text = s;
        }
        public void Setnameuser(string s)
        {
            lb_nameuser.Text = s;
        }
        public void Setmessage(string s)
        {
            lb_message.Text = s;
        }

        private async void btn_request_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string from = $"{username}";
            string to = $"{lb_nameuser.Text}";
            string message = "key encrypt";
            string body = "{\"from\": \"" + from + "\", \"to\": \"" + to + "\", \"message\": \"" + message + "\"}";

            StringContent content = new StringContent(body, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync($"{BaseURL}/api/communicate/send-request", content);

            if (response.IsSuccessStatusCode)
            {
                // Handle successful response
                string result = await response.Content.ReadAsStringAsync();
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
