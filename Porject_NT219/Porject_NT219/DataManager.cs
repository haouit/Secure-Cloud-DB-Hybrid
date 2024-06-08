using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using NT219_FinalProject.Crypto;

namespace NT219_FinalProject
{
    public partial class DataManager : Form
    {
        public DataManager()
        {
            InitializeComponent();
        }

        byte[] data;
        byte[] secret_key;
        byte[] iv;

        private void btn_dataload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                data = File.ReadAllBytes(openFileDialog.FileName);
                checkBox1.Checked = true;
                lb_namefile.Text = openFileDialog.SafeFileName;

            }
        }

        private void btn_loadkey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                secret_key = File.ReadAllBytes(openFileDialog.FileName);
                checkBox2.Checked = true;
                lb_namekey.Text = openFileDialog.SafeFileName;
            }
        }

        private void btn_loadiv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                iv = File.ReadAllBytes(openFileDialog.FileName);
                checkBox3.Checked = true;
                lb_nameiv.Text = openFileDialog.SafeFileName;
            }
        }

        private void btn_uploaddata_Click(object sender, EventArgs e)
        {
            //upload to server

            AES aes = new AES();
            string fileName = lb_namefile.Text;
            byte[] encryptedData = aes.Encrypt(data, secret_key, iv);



            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            data = null;
            secret_key = null;
            iv = null;
            lb_namefile.Text = "Name file";
            lb_namekey.Text = "Name file";
            lb_nameiv.Text = "Name file";
            this.Hide();
            this.Close();
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            byte[][] keyAndIV = aes.KeyIVGen();
            secret_key = keyAndIV[0];
            iv = keyAndIV[1];

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllBytes(fileName + "_key.bin", secret_key);
                File.WriteAllBytes(fileName + "_iv.bin", iv);
            }
            checkBox2.Checked = true;
            checkBox3.Checked = true;
        }
    }
}
