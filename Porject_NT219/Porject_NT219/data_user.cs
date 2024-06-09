using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NT219_FinalProject
{
    public partial class data_user : UserControl
    {
        const string BaseURL = Config.BaseURL;
        HttpClient client;
        string username;
        string filename;

        public data_user(HttpClient Client, string Username)
        {
            InitializeComponent();
            client = Client;
            username = Username;
        }

        public void Setnameuser(string s)
        {
            lb_nameuser.Text = s;
        }
        public void Setfilename(string s)
        {
            lb_filename.Text = s;
            filename = s;
        }
        public void Setmessage(string s)
        {
            lb_message.Text = s;
        }

        private async void btn_remove_Click(object sender, EventArgs e)
        {
            string url = $"{BaseURL}/api/data/remove-data";
            string body = "{\"author\": \"" + username + "\", \"filename\": \"" + filename + "\"}";
            StringContent content = new StringContent(body, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Remove data successfully");
            }
            else
            {
                MessageBox.Show("Remove data failed");
            }
        }
    }
}
