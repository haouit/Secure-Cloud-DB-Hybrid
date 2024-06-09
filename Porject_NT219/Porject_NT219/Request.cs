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
using NT219_FinalProject.Crypto;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace NT219_FinalProject
{
    public partial class Request : UserControl
    {
        const string BaseURL = Config.BaseURL;
        HttpClient client;
        string username;
        public Request(HttpClient Client, string Username)
        {
            InitializeComponent();
            client = Client;
            username = Username;
        }

        string publickey;

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
            publickey = s;
        }

        private async void btn_accept_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Secret Key Files (*.bin)|*.bin";
            openFileDialog.Title = "Select Secret Key File";
            MessageBox.Show("Please select your secret key file");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string secretKeyFilePath = openFileDialog.FileName;
                byte[] secertkey = System.IO.File.ReadAllBytes(secretKeyFilePath);

                RSA_Prj rsa = new RSA_Prj();
                RSAParameters public_key = rsa.ImportPublicKeyFromPem(publickey);
                byte[] encryptedSecretKey = rsa.Encrypt(secertkey);
                string encryptedSecretKeyBase64 = Convert.ToBase64String(encryptedSecretKey);

                string from = $"{lb_namerequest.Text}";
                string to = $"{username}";
                string message = encryptedSecretKeyBase64;
                string status = "accepted";
                string body = "{\"from\": \"" + from + "\", \"to\": \"" + to + "\", \"message\": \"" + message + "\", \"status\": \"" + status + "\"}";

                StringContent content = new StringContent(body, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync($"{BaseURL}/api/communicate/respond-request", content);

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

        private async void btn_remove_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string from = $"{lb_namerequest.Text}";
            string to = $"{username}";
            string status = "rejected";
            string body = "{\"from\": \"" + from + "\", \"to\": \"" + to + "\", \"status\": \"" + status + "\"}";

            StringContent content = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync($"{BaseURL}/api/communicate/respond-request", content);

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
