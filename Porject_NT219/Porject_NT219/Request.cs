using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NT219_FinalProject
{
    public partial class Request : UserControl
    {
        public Request(HttpClient client)
        {
            InitializeComponent();
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

        private async void btn_accept_Click(object sender, EventArgs e)
        {
            // đổi state
            // gửi key lên server
            // gửi request lên server
            HttpClient client = new HttpClient();
            string url = "http://localhost:3000/api/respond-request";
            string from = "a";
            string to = "b";
            string message = "Key encrypted";
            string state = "accepted";
            string body = "{\"from\": \"" + from + "\", \"to\": \"" + to + "\", \"message\": \"" + message + "\", \"response\": \"" + state + "\"}";

            StringContent content = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                // Handle successful response
                string result = await response.Content.ReadAsStringAsync();
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

        private async void btn_remove_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost:3000/api/respond-request";
            string from = "a";
            string to = "b";
            string state = "rejected";
            string body = "{\"from\": \"" + from + "\", \"to\": \"" + to + "\", \"response\": \"" + state + "\"}";

            StringContent content = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                // Handle successful response
                string result = await response.Content.ReadAsStringAsync();
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
