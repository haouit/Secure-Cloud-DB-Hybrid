﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NT219_FinalProject.Crypto;

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

        public void Setnameuser(string s)
        {
            lb_nameuser.Text = s;
        }
        public void Setfilename(string s)
        {
            lb_filename.Text = s;
        }
        public void Setmessage(string s)
        {
            lb_message.Text = s;
        }

        private async void btn_request_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Public Key File (*.pem)|*.pem";
            openFileDialog.Title = "Select Public Key File";
            MessageBox.Show("Please select your public key file");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string publicKeyFilePath = openFileDialog.FileName;
                byte[] publicKey = System.IO.File.ReadAllBytes(publicKeyFilePath);
                string publicKeyPEM = System.Text.Encoding.UTF8.GetString(publicKey);
                
                string from = $"{username}";
                string to = $"{lb_nameuser.Text}";
                string message = publicKeyPEM;
                string messageBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(message));
                string body = "{\"from\": \"" + from + "\", \"to\": \"" + to + "\", \"message\": \"" + messageBase64 + "\"}";

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
}
