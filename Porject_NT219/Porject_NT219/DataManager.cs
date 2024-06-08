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
    public partial class DataManager : Form
    {
        public DataManager()
        {
            InitializeComponent();
        }

        string filePath_data;
        string filePath_key;
        string filePath_iv;

        private void btn_dataload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath_data = openFileDialog.FileName;
                checkBox1.Checked = true;
                lb_namefile.Text = openFileDialog.SafeFileName;
            }
        }

        private void btn_loadkey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath_key = openFileDialog.FileName;
                checkBox2.Checked = true;
                lb_namekey.Text = openFileDialog.SafeFileName;
            }
        }

        private void btn_loadiv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath_iv = openFileDialog.FileName;
                checkBox3.Checked = true;
                lb_nameiv.Text = openFileDialog.SafeFileName;
            }            
        }

        private void btn_uploaddata_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            filePath_data = "";
            filePath_key = "";
            filePath_iv = "";
            lb_namefile.Text = "Name file";
            lb_namekey.Text = "Name file";
            lb_nameiv.Text = "Name file";
            //upload to server

            this.Hide();
            this.Close();
        }
    }
}
