using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porject_NT219
{
    public partial class DataManager : Form
    {
        public DataManager()
        {
            InitializeComponent();
        }

        string filePath_data;
        string data;
        string data_encrypted;

        private void btn_dataload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath_data = openFileDialog.FileName;
                data = File.ReadAllText(filePath_data);
            }
        }

        private void btn_savedata_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, data_encrypted);
            }
        }

        private void btn_uploaddata_Click(object sender, EventArgs e)
        {
            //upload to server

            this.Hide();
            this.Close();
        }

        private void btn_encyptdata_Click(object sender, EventArgs e)
        {
            //encrypt data

            this.Hide();
            this.Close();
        }
    }
}
