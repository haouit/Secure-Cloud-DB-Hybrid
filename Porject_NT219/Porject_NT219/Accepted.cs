﻿using NT219_FinalProject.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Org.BouncyCastle.Asn1.X9;

namespace NT219_FinalProject
{
    public partial class Accepted : UserControl
    {
        public Accepted()
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
            lb_key.Text = s;
        }

        private void btn_download_Click(object sender, EventArgs e)
        {

            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Private Key Files (*.pem)|*.pem";
            //openFileDialog.Title = "Select Private Key File";
            //MessageBox.Show("Please select your private key file");

            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string privateKeyFilePath = openFileDialog.FileName;
            //    RSA_Prj rsa = new RSA_Prj();
            //    rsa.ImportPrivateKeyFromPem(File.ReadAllText(privateKeyFilePath));

            //}
        }
    }
}
